<template>
  <div class="">
    <button
      @click="onPrimaryClick"
      class="flex items-center  justify-center w-12 h-12 rounded-full bg-white shadow hover:shadow-md transition-transform duration-150 transform hover:scale-110"
      :disabled="!googleReady"
      title="Login com Google"
    >
      <img src="/google.png" alt="Google Logo" class="w-6 h-6" />
    </button>

    <!-- container usado como fallback para renderButton se prompt falhar -->
    <div id="g_id_button_container" style="display:none;"></div>
  </div>
</template>

<script setup>
import { ref, onMounted, onBeforeUnmount } from "vue";
import { useRouter } from "vue-router";

const CLIENT_ID = "353535077307-nqv0s4rge8nh5d3a9eklcoacdijk61hf.apps.googleusercontent.com";
const googleReady = ref(false);
const router = useRouter();
let sdkScript = null;
let tokenClient = null;
let promptInProgress = false;

// Recebe o ID Token (One Tap / prompt)
function handleCredentialResponse(response) {
  const idToken = response?.credential;
  console.log("ID Token do Google:", idToken);
  // Envie ao backend quando disponível:
  // axios.post("/auth/google", { id_token: idToken }).then(...).catch(...);
}

// Callback para quando se obtiver um access token via oauth2.initTokenClient (fallback popup)
function handleAccessTokenResponse(tokenResponse) {
  console.log("Resposta OAuth (access token):", tokenResponse);
  // Se precisar do id_token via fluxo de servidor, use initCodeClient + troca no backend.
}

// Inicializa Google Identity Services e (opcional) Token Client para fallback popup
function initializeGoogleLogin() {
  if (window.google && window.google.accounts) {
    // initialize for One Tap / prompt
    try {
      window.google.accounts.id.initialize({
        client_id: CLIENT_ID,
        callback: handleCredentialResponse,
        auto_select: false, // evita seleção automática inesperada
      });
    } catch (e) {
      console.warn("Erro ao inicializar google.accounts.id:", e);
    }

    // tenta criar token client (popup) como alternativa (se desejar pegar access_token)
    try {
      if (window.google.accounts.oauth2 && window.google.accounts.oauth2.initTokenClient) {
        tokenClient = window.google.accounts.oauth2.initTokenClient({
          client_id: CLIENT_ID,
          scope: "openid email profile",
          callback: handleAccessTokenResponse,
        });
      }
    } catch (e) {
      // tokenClient pode não existir em todos os ambientes
      console.info("tokenClient não disponível:", e);
      tokenClient = null;
    }

    googleReady.value = true;
  } else {
    // espera e tenta novamente
    setTimeout(initializeGoogleLogin, 100);
  }
}

// Função que chama o prompt e trata "moment" notifications e erros (incluindo AbortError)
async function callPromptWithListener() {
  if (!window.google || !window.google.accounts || !window.google.accounts.id) return;

  // evita chamadas concorrentes
  if (promptInProgress) return;
  promptInProgress = true;

  try {
    window.google.accounts.id.prompt((moment) => {
      // trata os diferentes momentos (getNotDisplayedReason / getSkippedReason / getDismissedReason)
      try {
        if (moment.isNotDisplayed && moment.isNotDisplayed()) {
          console.log("Prompt não exibido:", moment.getNotDisplayedReason?.());
        } else if (moment.isSkipped && moment.isSkipped()) {
          console.log("Prompt pulado:", moment.getSkippedReason?.());
        } else if (moment.isDismissed && moment.isDismissed()) {
          console.log("Prompt dispensado:", moment.getDismissedReason?.());
        } else {
          console.log("Prompt exibido / credencial retornada.");
        }
      } catch (e) {
        console.log("Notificação do prompt recebida (formato inesperado).", e);
      }
    });
  } catch (err) {
    // Trata AbortError e outros
    if (err && err.name === "AbortError") {
      console.warn("Prompt abortado pelo navegador (AbortError). Renderizando fallback do botão do Google.");
      renderFallbackButton();
    } else {
      console.error("Erro ao chamar google.accounts.id.prompt():", err);
      renderFallbackButton();
    }
  } finally {
    promptInProgress = false;
  }
}

// Renderiza o botão oficial do Google como fallback e exibe no DOM
function renderFallbackButton() {
  try {
    const container = document.getElementById("g_id_button_container");
    if (!container) return;
    if (window.google && window.google.accounts && window.google.accounts.id && container) {
      // limpa container antes de renderizar
      container.innerHTML = "";
      window.google.accounts.id.renderButton(container, {
        theme: "outline",
        size: "large",
      });
      container.style.display = "block";
    }
  } catch (e) {
    console.error("Erro ao renderizar botão fallback:", e);
  }
}

// Ação principal do botão: tenta prompt; se não disponível, usa tokenClient (popup) ou renderButton fallback
async function onPrimaryClick() {
  if (!googleReady.value) {
    console.warn("Google SDK ainda não pronto.");
    return;
  }

  // tenta prompt primeiro
  try {
    await callPromptWithListener();
  } catch (e) {
    console.debug("callPromptWithListener rejeitado:", e);
  }

  // se prompt não apresentou credencial e tokenClient está disponível, abrir popup como alternativa
  // (isso requer consentimento do usuário e oferece access_token, não id_token automaticamente)
  if (!promptInProgress && !tokenClient) {
    // se tokenClient não existe, mostra botão fallback para interação manual
    renderFallbackButton();
  } else if (!promptInProgress && tokenClient) {
    // solicitar access token via popup como alternativa (requer interação explícita)
    try {
      tokenClient.requestAccessToken({ prompt: "" });
    } catch (e) {
      console.warn("Falha ao solicitar access token via tokenClient:", e);
      renderFallbackButton();
    }
  }
}

function loadGsiScript() {
  return new Promise((resolve, reject) => {
    if (document.getElementById("google-identity-services")) {
      resolve();
      return;
    }
    sdkScript = document.createElement("script");
    sdkScript.src = "https://accounts.google.com/gsi/client";
    sdkScript.id = "google-identity-services";
    sdkScript.async = true;
    sdkScript.defer = true;
    sdkScript.onload = () => resolve();
    sdkScript.onerror = (e) => reject(e);
    document.head.appendChild(sdkScript);
  });
}

onMounted(async () => {
  try {
    await loadGsiScript();
    initializeGoogleLogin();
    // tenta exibir prompt automaticamente (One Tap) ao montar — captura AbortError e faz fallback
    callPromptWithListener();
  } catch (e) {
    console.error("Falha ao carregar GSI script:", e);
    renderFallbackButton();
  }
});

onBeforeUnmount(() => {
  if (sdkScript && sdkScript.parentNode) sdkScript.parentNode.removeChild(sdkScript);
});
</script>

<style scoped>
button:hover {
  cursor: pointer;
}
</style>
