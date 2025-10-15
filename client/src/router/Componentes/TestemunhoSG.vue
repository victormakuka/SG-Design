<script setup>
import { useRouter } from 'vue-router';
const router = useRouter() // Instancia do roteador
import { ref } from "vue";




function irPara(path) {
  router.push(path)
}
</script>


<template>
     <!-- Testemunhos -->
  <section class="border-t border-b border-t-preto2 border-b-preto2 text-white px-6 py-12">
    <div class="max-w-6xl mx-auto grid md:grid-cols-2 gap-8 items-center">
      <h2 class="text-2xl md:text-3xl font-bold mb-4">Testemunhos</h2>
    </div>

    <div>
      <div class="overflow-x-auto">
        <div class="flex space-x-6 p-4 md:justify-center">
          <!-- Card 1 -->
          <div class="bg-preto2 h-40 min-w-[250px] rounded-xl shadow-md p-4">
            <div class="flex space-x-2">
              <div class="h-12 w-12 bg-amarelo rounded-3xl overflow-hidden">
                <img src="/Makuka.jpg" class="object-cover" alt="" />
              </div>
              <div class="flex flex-col">
                <span class="font-bold font-montserrat">Victor Makuka</span>
                <span class="text-sm font-light font-montserrat text-amarelo">Programador</span>
              </div>
            </div>

            <p class="py-6">"Qualidade excepcional e atenção aos detalhes!"</p>
          </div>

          <!-- Testemunho 2 -->
          <div class="bg-preto2 h-40 min-w-[250px] rounded-xl shadow-md p-4">
            <div class="flex space-x-2">
              <div class="h-12 w-12 bg-amarelo rounded-3xl overflow-hidden">
                <img src="/Makuka.jpg" class="object-cover" alt="" />
              </div>
              <div class="flex flex-col">
                <span class="font-bold font-montserrat">Séfora Zípora</span>
                <span class="text-sm font-light font-montserrat text-amarelo">Analista</span>
              </div>
            </div>

            <p class="py-6">"Seus designs transformaram nossa imagem de marca!"</p>
          </div>

          <!-- Testemunho 3 -->

          <div class="bg-preto2 h-40 min-w-[250px] rounded-xl shadow-md p-4">
            <div class="flex space-x-2">
              <div class="h-12 w-12 bg-amarelo rounded-3xl overflow-hidden">
                <img src="/Makuka.jpg" class="object-cover" alt="" />
              </div>
              <div class="flex flex-col">
                <span class="font-bold font-montserrat">Edvaldo Dantas</span>
                <span class="text-sm font-light font-montserrat text-amarelo">Programador</span>
              </div>
            </div>

            <p class="py-6">"O trabalho deles superou nossas expectativas!"</p>
          </div>
        </div>
      </div>
    </div>
    <div class="flex justify-center items-center py-4">
      <a ref="" 
        class="border rounded-3xl border-amarelo px-2 py-2 text-amarelo text-xs md:text-md cursor" @click="irPara('/TodosComentarios')"
        >Ver todos Comentários</a
      >
    </div>
  </section>

</template>