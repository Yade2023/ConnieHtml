<template>
  <footer class="site-footer">
    <div class="footer-content">
      <a class="footer-link" href="/" target="_self">康妮泌乳美學 首頁</a>
      <span class="footer-divider">|</span>
      <span class="footer-counter">瀏覽人次：{{ viewCount }}</span>
    </div>
  </footer>
</template>

<script setup>
import { ref, onMounted } from 'vue';

const viewCount = ref(0);

onMounted(() => {
  // 計數器只在本機顯示（可用密碼或特定條件顯示）
  // 這裡先用localStorage模擬
  let count = localStorage.getItem('connie-visit-count');
  if (!count) count = 0;
  count = parseInt(count) + 1;
  localStorage.setItem('connie-visit-count', count);
  viewCount.value = count;
});
</script>

