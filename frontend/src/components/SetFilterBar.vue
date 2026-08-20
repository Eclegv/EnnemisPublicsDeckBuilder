<template>
  <div class="set-filter-bar">
    <div class="set-filter-label">Sets</div>
    <div class="set-filter-scroll">
      <button
        v-for="set in sets"
        :key="set.id || set.guid"
        class="set-pill"
        :class="{ active: isSetSelected(set.id || set.guid) }"
        @click="toggleSet(set.id || set.guid)"
      >
        <span class="set-name">{{ set.name }}</span>
        <span class="set-count">{{ set.cardCount ?? '?' }}</span>
      </button>
    </div>
  </div>
</template>

<script setup>
import { sets, isSetSelected, toggleSet } from '../stores/deck.js'
</script>

<style scoped>
.set-filter-bar {
  display: flex;
  align-items: center;
  gap: 0.75rem;
  padding: 0.75rem 1.5rem;
  background: #142414;
  border-bottom: 1px solid #2b5035;
  flex-shrink: 0;
}

.set-filter-label {
  font-family: 'Cinzel', serif;
  font-size: 0.8rem;
  font-weight: 600;
  color: #7aaa6a;
  text-transform: uppercase;
  letter-spacing: 0.08em;
  white-space: nowrap;
}

.set-filter-scroll {
  display: flex;
  gap: 0.5rem;
  overflow-x: auto;
  flex: 1;
  padding-bottom: 2px;
}

.set-pill {
  display: flex;
  align-items: center;
  gap: 0.4rem;
  padding: 0.4rem 0.85rem;
  background: #1a2e1a;
  border: 1px solid #2b5035;
  border-radius: 8px;
  cursor: pointer;
  white-space: nowrap;
  transition: all 0.15s ease;
  user-select: none;
  color: inherit;
  font: inherit;
}

.set-pill:hover {
  border-color: #d4af37;
}

.set-pill.active {
  background: #1f3a1f;
  border-color: #d4af37;
  box-shadow: 0 0 10px rgba(212, 175, 55, 0.2);
}

.set-name {
  font-size: 0.85rem;
  color: #c8d8a8;
}

.set-pill.active .set-name {
  color: #f0d878;
}

.set-count {
  font-size: 0.75rem;
  color: #4a7a55;
  background: #0d1f12;
  padding: 0.1rem 0.4rem;
  border-radius: 4px;
}

.set-pill.active .set-count {
  color: #d4af37;
}
</style>
