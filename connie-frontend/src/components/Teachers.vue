<template>
  <div class="teachers-page">
    <h1>老師介紹</h1>
    <ul>
      <li v-for="item in teachers" :key="item.Id">
        <strong>{{ item.name }}</strong>（{{ item.title }}）：{{ item.description }}
      </li>
    </ul>
  </div>
</template>

<script setup>
// 樣式已移至 assets/css/teachers.css
import { ref, onMounted } from 'vue';
import axios from 'axios';
const teachers = ref([]);
onMounted(async () => {
  const res = await axios.get('http://localhost:5028/api/teachers');
  console.log(res.data);
  teachers.value = res.data;
});
</script> 