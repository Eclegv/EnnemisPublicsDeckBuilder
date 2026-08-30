<template>
  <div class="button-wrapper">
    <button ref="container" class="main-button" @click.stop="toggleTooltip">
      <span v-if="errors" class="material-symbols-outlined"> warning </span>
      <span v-else class="checked material-symbols-outlined"> check </span>
    </button>

    <Teleport to="body">
      <div
        ref="floating"
        :style="floatingStyles"
        v-if="open && errors !== '' && errors !== null && errors !== undefined"
        class="tooltip"
      >
        {{ errors }}
      </div>
    </Teleport>
  </div>
</template>

<script setup>
import { ref, onMounted, onBeforeUnmount } from "vue";
import { useFloating, autoPlacement, autoUpdate, arrow } from "@floating-ui/vue";

defineProps({
  errors: {
    type: String,
    required: true,
    default: "",
  },
});

const open = ref(false);
const container = ref(null);
const floating = ref(null);

const { floatingStyles, middlewareData } = useFloating(container, floating, {
  placement: "bottom-end",
});

function toggleTooltip() {
  open.value = !open.value;
}

function handleOutsideClick(event) {
  if (container.value && !container.value.contains(event.target)) {
    open.value = false;
  }
}

onMounted(() => {
  document.addEventListener("click", handleOutsideClick);
});

onBeforeUnmount(() => {
  document.removeEventListener("click", handleOutsideClick);
});
</script>

<style scoped>
.material-symbols-outlined {
  font-variation-settings: "FILL" 0, "wght" 400, "GRAD" 0, "opsz" 24;
}

.button-wrapper {
  position: relative;
  display: inline-block;
}

.main-button {
  font-family: "Cinzel", serif;
  font-size: 1.2rem;
  font-weight: 700;
  color: #d4af37;
  background: #1a2e1a;
  padding: 0.3rem 0.3rem;
  border-radius: 6px;
  border: 1px solid #2b5035;
  cursor: pointer;
  border: 0;
  background: none;
  box-shadow: none;
}

.checked {
  color: #10df4a;
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
  font-family: "Cinzel", serif;
  font-size: 0.95rem;

  padding: 10px;

  background: #333;
  color: white;
  border-radius: 6px;

  white-space: pre-wrap;
  width: max-content;

  z-index: 99999;
}
</style>
