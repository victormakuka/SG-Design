<script setup>
import { useRouter } from 'vue-router';
const router = useRouter() // Instancia do roteador


function irPara(path) {
  router.push(path)
}
</script>

<template>
   
     <header class="fixed top-0 left-0 w-full flex items-center justify-between p-3 shadow-md lg:p-8 lg:h-20 h-20 z-50 bg-preto2 ">
    <img src='/public/Logo web.png' alt="Logo" class="h-7 w-auto lg:h-10" />
    
    <nav class="space-x-2 text-sm flex text-white lg:space-x-8 lg:text-xl">
         <RouterLink to="/" class="hover:text-amarelo">Home</RouterLink>
    <RouterLink to="/#servicos" class="hover:text-amarelo">Serviços</RouterLink>
    <RouterLink to="/#sobre" class="hover:text-amarelo">Sobre</RouterLink>
    <RouterLink to="/projectos-servicos" class="hover:text-amarelo">Projetos</RouterLink>
      <div class="bg-amarelo px-1 py-0.5 text-white rounded-xl hover:bg-yellow-500 lg:px-3 lg:py-1">
        <RouterLink to="/#contactos" class="hover:text-white">Contactos</RouterLink>
      </div>
    </nav>
  </header>
</template>

