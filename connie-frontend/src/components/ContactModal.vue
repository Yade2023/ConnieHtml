<template>
  <div v-if="show" class="modal-overlay" @click.self="close">
    <div class="modal-content">
      <img src="/ConnieLineQRCode.jpg" alt="Line QR Code" class="qrcode-img" />
      <button class="close-btn" @click="close">關閉</button>
    </div>
  </div>
</template>

<script setup>
import { defineProps, defineEmits } from 'vue';
const props = defineProps({ show: Boolean });
const emit = defineEmits(['close']);
const close = () => emit('close');
</script> 