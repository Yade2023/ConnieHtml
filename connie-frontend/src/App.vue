<script setup>
import Footer from './components/Footer.vue';
import { ref } from 'vue';
import ContactModal from './components/ContactModal.vue';

const showModal = ref(false);
</script>

<template>
  <div id="app">
    <nav class="navbar">
      <router-link to="/" class="logo-link">
        <img src="/LOGO.png" alt="logo" class="main-logo" />
        <span class="brand">康妮泌乳美學</span>
      </router-link>
      <div class="nav-links">
        <router-link to="/news">最新消息</router-link>
        <router-link to="/teachers">老師介紹</router-link>
        <router-link to="/services">服務項目</router-link>
      </div>
      <div class="nav-icons">
        <a href="https://www.instagram.com/connie_cares_spa/" target="_blank" class="icon-btn">
          <img src="/IG.png" alt="IG" />
        </a>
        <a href="https://www.facebook.com/conniecares1990" target="_blank" class="icon-btn">
          <img src="/FB.ico" alt="FB" />
        </a>
        <a href="#" class="icon-btn contact-link" @click.prevent="showModal = true">連絡我們／預約諮詢</a>
      </div>
    </nav>
    <main class="main-content">
      <router-view />
    </main>
    <ContactModal :show="showModal" @close="showModal = false" />
    <Footer />
  </div>
</template>

<style scoped>
#app {
  font-family: 'Noto Sans TC', Arial, sans-serif;
  background: #faf7f9;
  min-height: 100vh;
}
.navbar {
  display: flex;
  align-items: center;
  justify-content: space-between;
  background: #fff;
  padding: 0.5rem 2rem;
  box-shadow: 0 2px 8px rgba(233,174,188,0.06);
  position: sticky;
  top: 0;
  z-index: 100;
}
.logo-link {
  display: flex;
  align-items: center;
  text-decoration: none;
}
.main-logo {
  height: 40px;
  width: 40px;
  object-fit: contain;
  border-radius: 50%;
  background: #fff;
  margin-right: 10px;
}
.brand {
  font-size: 1.5rem;
  color: #e9aebc;
  font-weight: bold;
  letter-spacing: 2px;
}
.nav-links {
  display: flex;
  gap: 1.5rem;
}
.nav-links a {
  color: #6c757d;
  font-size: 1.08rem;
  text-decoration: none;
  border-radius: 8px;
  padding: 0.5rem 1rem;
  transition: background 0.3s, color 0.3s;
}
.nav-links a.router-link-exact-active, .nav-links a:hover {
  background: linear-gradient(90deg, #f8e1e7 0%, #f3f3f3 100%);
  color: #d16d8a;
}
.nav-icons {
  display: flex;
  gap: 0.5rem;
}
.icon-btn {
  background: linear-gradient(90deg, #f8e1e7 0%, #f3f3f3 100%);
  border-radius: 2em;
  padding: 0.3em 1.1em;
  display: flex;
  align-items: center;
  border: none;
  transition: background 0.3s, box-shadow 0.3s;
  box-shadow: none;
}
.icon-btn img {
  height: 22px;
  width: 22px;
  object-fit: contain;
}
.main-content {
  max-width: 1600px;
  margin: 2rem auto 0 auto;
  background: #fff;
  border-radius: 16px;
  box-shadow: 0 2px 16px rgba(233,174,188,0.06);
  padding: 2rem 2.5rem;
}
@media (max-width: 991px) {
  .navbar { flex-direction: column; align-items: flex-start; padding: 1rem; }
  .main-content { padding: 1rem; }
}
.site-footer {
  width: 100%;
  background: #f8f3f6;
  color: #b97a95;
  text-align: center;
  padding: 18px 0 10px 0;
  font-size: 1.1rem;
  position: relative;
  bottom: 0;
  left: 0;
  border-top: 1px solid #f0e0e7;
  margin-top: 16px;
}
.contact-link {
  font-size: 1.08rem;
  font-weight: bold;
  color: #b97a95;
  background: linear-gradient(90deg, #f8e1e7 0%, #f3f3f3 100%);
  border-radius: 2em;
  padding: 0.3em 1.1em;
  margin-left: 0.5rem;
  text-decoration: none;
  transition: background 0.3s, color 0.3s;
  display: flex;
  align-items: center;
  border: none;
  box-shadow: none;
}
.contact-link:hover {
  color: #e573b7;
  background: #f8e1e7;
}
</style>
