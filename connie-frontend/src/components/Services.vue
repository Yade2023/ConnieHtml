<template>
  <div class="services-page">
    <h1>服務項目</h1>
    <ul>
      <li v-for="item in services" :key="item.Id">
        <strong>{{ item.name }}</strong>：{{ item.description }}
      </li>
    </ul>
  </div>
</template>

<script setup>
// 樣式已移至 assets/css/services.css
import { ref, onMounted } from 'vue';
import axios from 'axios';
const services = ref([]);
onMounted(async () => {
  const res = await axios.get('http://localhost:5028/api/services');
  console.log(res.data);
  services.value = res.data;
});
</script> 