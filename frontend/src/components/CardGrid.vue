<template>
  <div class="card-grid">
    <CardItem v-for="card in cards" :key="card.id" :card="card" />
  </div>
</template>

<script setup>
import { addToDeck } from "../stores/deck.js";
import CardItem from "./CardItem.vue";

defineProps({
  cards: {
    type: Array,
    required: true,
  },
});
</script>

<style scoped>
.card-grid {
  flex: 1;
  overflow-y: auto;
  padding: 1.5rem;
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(15rem, 1fr));
  gap: 1.5rem;
  align-content: start;
}

@media (max-width: 768px) {
  .card-grid {
    grid-template-columns: repeat(auto-fill, minmax(10rem, 1fr));
  }
}
</style>
