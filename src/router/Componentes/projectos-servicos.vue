    
<script setup>
import Navbar from './navbar.vue';
import { useRouter } from 'vue-router';
const router = useRouter() // Instancia do roteador


function irPara(path) {
  router.push(path)
}
</script>


<template>
    <!-- Header -->
<Navbar/>



    <!-- Nossos Projectos -->
    <section class="">
        <div class="relative w-full h-96">
            <img src="/web.jpg" alt="" class="opacity-20 w-full h-96 object-cover object-center" />

            <div class="absolute inset-0 flex items-center justify-center flex-col">
                <p class="text-2xl md:text-3xl font-bold mb-4 font-montserrat tracking-wide text-center p-6 text-amarelo">
                    Nossos Projectos Incriveis
                </p>
               <p class="text-center lg:text-xl  font-regular p-4 mt-[-50px]">Descubra o portfólio de designs gráficos que transformam ideias em realidade. Modernos, vibrantes e cheios de vida!</p>
            </div>
        </div> 
    </section>

    <!-- Serviços dos Projectos -->
   <section class="">

    <!-- Serviços -->
     <div class="p-6 md:p-10 xl:px-40">
  <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">
    
    <!-- Identidade Visual -->
      <div class="bg-preto2 rounded-xl p-8 shadow-sm transition-all duration-300 hover:shadow-lg hover:border-red-600">
  <p class="text-xl font-bold font-montserrat mb-4">Identidade Visual</p>
  <p>Design de flyers impactantes para eventos, promoções e campanhas publicitárias.</p>

  <div class="space-y-2 py-2">
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Logotipos Profissionais
    </p>
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Manual da Marca
    </p>
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Cores e Tipografia
    </p>
    
  </div>
 <div class="flex items-center justify-center pt-4">
  <button
    class="text-amarelo text-sm border border-amarelo rounded-3xl px-4 py-2 
           transition-all duration-300 
           hover:bg-amarelo hover:text-preto
           sm:px-5 sm:py-2 md:px-6 md:py-2.5 lg:px-8 lg:py-3" @click="irPara('/IdentidadeVisual')">
    Ver todos projectos
  </button>
</div>

</div>

    <!-- Flyers -->
    <div class="bg-preto2 rounded-xl p-8 shadow-sm transition-all duration-300 hover:shadow-lg hover:border-red-600">
  <p class="text-xl font-bold font-montserrat mb-4">Flyers & Banners</p>
  <p>Design de flyers impactantes para eventos, promoções e campanhas publicitárias.</p>

  <div class="space-y-2 py-2">
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Logotipos Profissionais
    </p>
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Manual da Marca
    </p>
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Cores e Tipografia
    </p>
  </div>
   <div class="flex items-center justify-center pt-4">
  <button
    class="text-amarelo text-sm border border-amarelo rounded-3xl px-4 py-2 
           transition-all duration-300 
           hover:bg-amarelo hover:text-preto
           sm:px-5 sm:py-2 md:px-6 md:py-2.5 lg:px-8 lg:py-3" @click="irPara('/FlyersEventos')">
    Ver todos projectos
  </button>
</div>
</div>


    <!-- Flyers -->
    <div class="bg-preto2 rounded-xl p-8 shadow-sm transition-all duration-300 hover:shadow-lg hover:border-red-600">
  <p class="text-xl font-bold font-montserrat mb-4">Logotipos</p>
  <p>Design de flyers impactantes para eventos, promoções e campanhas publicitárias.</p>

  <div class="space-y-2 py-2">
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Logotipos Profissionais
    </p>
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Manual da Marca
    </p>
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Cores e Tipografia
    </p>
  </div>
   <div class="flex items-center justify-center pt-4">
  <button
    class="text-amarelo text-sm border border-amarelo rounded-3xl px-4 py-2 
           transition-all duration-300 
           hover:bg-amarelo hover:text-preto
           sm:px-5 sm:py-2 md:px-6 md:py-2.5 lg:px-8 lg:py-3" @click="irPara('/LogotiposProfissionais')">
    Ver todos projectos
  </button>
</div>

   </div>
  </div>
</div>

<!-- Serviços Parte II -->
 
     <div class="p-6 md:p-10 xl:px-40">
  <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8">


    <!-- Cartão de Visitas e Passes -->
      <div class="bg-preto2 rounded-xl p-8 shadow-sm transition-all duration-300 hover:shadow-lg hover:border-red-600">
  <p class="text-xl font-bold font-montserrat mb-4">Cartão de Visitas & Passes</p>
  <p>Design de flyers impactantes para eventos, promoções e campanhas publicitárias.</p>

  <div class="space-y-2 py-2">
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Logotipos Profissionais
    </p>
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Manual da Marca
    </p>
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Cores e Tipografia
    </p>
  </div>
     <div class="flex items-center justify-center pt-4">
  <button
    class="text-amarelo text-sm border border-amarelo rounded-3xl px-4 py-2 
           transition-all duration-300 
           hover:bg-amarelo hover:text-preto
           sm:px-5 sm:py-2 md:px-6 md:py-2.5 lg:px-8 lg:py-3" @click="irPara('/CartaodeVisita')">
    Ver todos projectos
  </button>
</div>
</div>


    <!-- Criação de Sites-->
  <div class="bg-preto2 rounded-xl p-8 shadow-sm transition-all duration-300 hover:shadow-lg hover:border-red-600">
  <p class="text-xl font-bold font-montserrat mb-4">Criação de Sites</p>
  <p>Design de flyers impactantes para eventos, promoções e campanhas publicitárias.</p>

  <div class="space-y-2 py-2">
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Logotipos Profissionais
    </p>
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Manual da Marca
    </p>
    <p class="flex items-center gap-2 ">
      <svg xmlns="http://www.w3.org/2000/svg" class="text-amarelo h-5" width="24" height="24" viewBox="0 0 24 24"><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M20 6L9 17l-5-5"/></svg>
      Cores e Tipografia
    </p>
  </div>
     <div class="flex items-center justify-center pt-4">
  <button
    class="text-amarelo text-sm border border-amarelo rounded-3xl px-4 py-2 
           transition-all duration-300 
           hover:bg-amarelo hover:text-preto
           sm:px-5 sm:py-2 md:px-6 md:py-2.5 lg:px-8 lg:py-3" @click="irPara('/CriacaoSites')">
    Ver todos projectos
  </button>
</div>
</div>




  </div>
</div>

   </section>
</template>