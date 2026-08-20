<template>
  <div class="app">
    <BuilderView />
  </div>
</template>

<script setup>
import BuilderView from './views/BuilderView.vue'
</script>

<style>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-family: 'Crimson Text', 'Georgia', serif;
  background: #0d1f12;
  color: #e8dcc8;
  min-height: 100vh;
  overflow: hidden;
}

.app {
  height: 100vh;
  display: flex;
  flex-direction: column;
}

::-webkit-scrollbar {
  width: 8px;
  height: 8px;
}

::-webkit-scrollbar-track {
  background: #0f1f12;
}

::-webkit-scrollbar-thumb {
  background: #2b5035;
  border-radius: 4px;
}

::-webkit-scrollbar-thumb:hover {
  background: #3a6b45;
}
</style>
