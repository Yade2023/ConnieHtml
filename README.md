# 康妮泌乳美學 - 純前端靜態網站

這是一個純前端的 Vue.js 靜態網站，專為康妮泌乳美學設計。

## 功能特色

- 🏠 **首頁** - 展示品牌形象和主要服務
- 📰 **最新消息** - 顯示 Facebook 粉絲專頁動態
- 👩‍🏫 **老師介紹** - 專業團隊介紹
- 🛍️ **服務項目** - 詳細的服務內容和價格
- 📞 **聯絡我們** - 預約諮詢功能

## 技術棧

- **Vue 3** - 現代化前端框架
- **Vue Router** - 單頁應用路由
- **Vite** - 快速建構工具
- **CSS3** - 響應式設計

## 快速開始

### 安裝依賴

```bash
cd connie-frontend
npm install
```

### 開發模式

```bash
npm run dev
```

### 建構生產版本

```bash
npm run build
```

### 預覽生產版本

```bash
npm run preview
```

## 部署

建構完成後，`dist` 目錄包含所有靜態文件，可以直接部署到任何靜態網站託管服務：

- GitHub Pages
- Netlify
- Vercel
- 任何 Web 服務器

## 項目結構

```
connie-frontend/
├── public/                 # 靜態資源
│   ├── LOGO.png           # 品牌 Logo
│   ├── ConnieCares.png    # 品牌圖片
│   ├── FB.ico            # Facebook 圖示
│   ├── IG.png            # Instagram 圖示
│   └── ...
├── src/
│   ├── components/        # Vue 組件
│   │   ├── Home.vue      # 首頁
│   │   ├── News.vue      # 最新消息
│   │   ├── Teachers.vue  # 老師介紹
│   │   ├── Services.vue  # 服務項目
│   │   ├── ContactModal.vue # 聯絡模態框
│   │   └── Footer.vue    # 頁尾
│   ├── assets/           # 資源文件
│   │   └── css/         # 樣式文件
│   ├── router/           # 路由配置
│   └── main.js          # 應用入口
├── index.html            # HTML 模板
├── package.json          # 項目配置
└── vite.config.js       # Vite 配置
```

## 自定義

### 修改服務項目

編輯 `src/components/Services.vue` 中的 `staticServices` 數組。

### 修改老師介紹

編輯 `src/components/Teachers.vue` 中的 `staticTeachers` 數組。

### 修改樣式

編輯 `src/assets/css/` 目錄下的 CSS 文件。

## 瀏覽器支援

- Chrome (最新版本)
- Firefox (最新版本)
- Safari (最新版本)
- Edge (最新版本)

## 授權

此項目僅供康妮泌乳美學使用。
