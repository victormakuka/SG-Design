<script setup>
import ContactosSG from './ContactosSG.vue';
import FooterSG from './FooterSG.vue';
import NavBar from './navbar.vue';
import PassosCriacao from './PassosCriacao.vue';
import ProjectoDestaques from './ProjectoDestaques.vue';
import ServicoSG from './ServicoSG.vue';
import SobreNos from './SobreNos.vue';
import TestemunhoSG from './TestemunhoSG.vue';



</script>
<template>
   <NavBar/>
   

    <!-- Pagina inicial Home -->
    <section class="bg-preto pt-20 lg:pt-20 relative z-0" id="home">
      <img src="/web.jpg" alt="" class="opacity-20 w-full h-96 object-cover object-center" />
      <div class="relative w-full"></div>
      <img src="" alt="" class="w-full h-auto object-contain opacity-40" />
      <div
        class="absolute inset-0 flex flex-col justify-center items-start px-8 lg:px-[100px] py-8 lg:py-24"
      >
        <p
          class="font-montserrat text-xl font-medium lg:text-4xl md:text-4xl text-white drop-shadow-lg"
        >
          Exiba sua marca com
        </p>
        <p
          class="text-white text-xl font-montserrat font-bold tracking-wide lg:text-6xl md:text-5xl drop-shadow-lg"
        >
          designs impressionantes!
        </p>
      </div>
    </section>

    <!-- Algumas Acções -->

    <section class="">
      <div
        class="border-b border-t border-t-preto2 border-b-preto2 lg:p-14 p-8 h-[100px] lg:h-[150px] lg:px-[400px] md:px-[150px]"
      >
        <div class="flex justify-between">
          <div
            class="bg-amarelo rounded-3xl px-1 py-1 lg:py-2 lg:px-2 lg:text-lg font-montserrat text-sm"
          >
            Ver mais
          </div>
          <div
            class="bg-amarelo rounded-3xl px-1 py-1 font-montserrat text-sm lg:py-2 lg:px-2 lg:text-lg"
          >
            Ver mais
          </div>
          <div
            class="bg-amarelo rounded-3xl px-1 py-1 font-montserrat text-sm lg:py-2 lg:px-2 lg:text-lg"
          >
            Ver mais
          </div>
          <div
            class="bg-amarelo rounded-3xl px-1 py-1 font-montserrat text-sm lg:py-2 lg:px-2 lg:text-lg"
          >
            Ver mais
          </div>
        </div>
      </div>
    </section>

    <!-- Nossos Serviços -->
     <ServicoSG/>
 
<!-- Projectos em Destaques -->

   <ProjectoDestaques/>

    <!--Nossos Passos Criação  -->
    <PassosCriacao/>

  <!-- Traformação do Projecto-->
  <section>
    <div class="border-b border-t border-t-preto2 border-b-preto2 p-4 pb-16">
      <p
        class="text-2xl md:text-3xl font-bold mb-4 font-montserrat font-bold tracking-wide text-center p-6 tracking-wide text-amarelo"
      >
        Pronto para transformar seu projeto?
      </p>
      <p class="text-center lg:text-xl font-montserrat font-regular p-4 mt-[-30px]">
        Entre em contato hoje mesmo e vamos conversar sobre como podemos elevar sua presença visual
      </p>

      <div class="flex justify-center items-center">
        <button class="border rounded-3xl border-amarelo px-2 py-2 text-amarelo text-xs md:text-md">
          Solicitar Orçamento
        </button>
      </div>
    </div>
  </section>

<!-- Sobre Nós -->
<SobreNos/>


  <!-- Testemunhos -->
<TestemunhoSG/>

<!-- Contactos -->
<ContactosSG/>

<!-- Footer -->
 <FooterSG/>
</template>
