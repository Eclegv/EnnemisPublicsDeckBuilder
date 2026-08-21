<template>
  <div ref="container" class="button-wrapper">
    <button class="main-button" @click.stop="toggleTooltip">
      <slot />
      ⚠
    </button>

    <button
      class="counter"
      @click.stop="toggleTooltip"
    >
      {{ errors.count }}
    </button>

    <div v-if="open" class="tooltip">
      {{ errors.text }}
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted, onBeforeUnmount } from 'vue'

defineProps({
  errors: {
    type: Object,
    required: true,
    default: () => ({})
  }
})

const open = ref(false)
const container = ref(null)

function toggleTooltip() {
  open.value = !open.value
}

function handleOutsideClick(event) {
  if (
    container.value &&
    !container.value.contains(event.target)
  ) {
    open.value = false
  }
}

onMounted(() => {
  document.addEventListener('click', handleOutsideClick)
})

onBeforeUnmount(() => {
  document.removeEventListener('click', handleOutsideClick)
})
</script>

<style scoped>
.button-wrapper {
  position: relative;
  display: inline-block;
}

.main-button {
  font-family: 'Cinzel', serif;
  font-size: 1.2rem;
  font-weight: 700;
  color: #d4af37;
  background: #1a2e1a;
  padding: 0.3rem 1.1rem;
  border-radius: 6px;
  border: 1px solid #2b5035;
  cursor: pointer;
}

.counter {
  position: absolute;
  bottom: -8px;
  left: -8px;

  min-width: 1rem;
  height: 1rem;

  border: none;
  border-radius: 50%;

  background: #cb6a68;
  color: white;

  font-size: 12px;
  font-weight: bold;
  cursor: pointer;
}

.tooltip {
  position: absolute;

  font-family: 'Cinzel', serif;
  font-size: 0.95rem;

  top: 100%;
  right: 100%;

  width: 250px;
  padding: 10px;

  background: #333;
  color: white;
  border-radius: 6px;
  
  white-space: pre-wrap;
  width: max-content;

  z-index: 1000;
}
</style>