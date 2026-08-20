<template>
  <div class="deck-card-item">
    <div class="deck-card-cost" v-if="item.card.cost">
      <span
        class="cost-badge"
        :style="{ background: costColor(item.card.cost) }"
        :title="item.card.cost"
      >
        {{ costIcon(item.card.cost) }}
      </span>
    </div>
    <div class="deck-card-cost empty" v-else></div>

    <div class="deck-card-name">{{ item.card.name }}</div>

    <div class="deck-card-qty">
      <button class="qty-btn" @click="removeFromDeck(item.card)">−</button>
      <span class="qty-value">{{ item.count }}</span>
      <button class="qty-btn" @click="addToDeck(item.card)">+</button>
    </div>
  </div>
</template>

<script setup>
import { addToDeck, removeFromDeck, COLORS, ICONS } from '../stores/deck.js'

defineProps({
  item: {
    type: Object,
    required: true
  }
})

function costColor(cost) {
  return COLORS[cost] || '#666'
}

function costIcon(cost) {
  return ICONS[cost] || '?'
}
</script>

<style scoped>
.deck-card-item {
  display: flex;
  align-items: center;
  gap: 0.5rem;
  padding: 0.5rem 0.9rem;
  margin: 0.2rem 0.75rem;
  border: 1px solid #2b5035;
  border-radius: 8px;
  background: #1a2e1a;
  transition: all 0.15s;
}

.deck-card-item:hover {
  background: #1f3a1f;
  border-color: #d4af37;
}

.deck-card-cost {
  flex-shrink: 0;
}

.cost-badge {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  width: 20px;
  height: 20px;
  border-radius: 4px;
  font-size: 0.6rem;
  font-weight: 700;
  color: #fff;
  text-shadow: 0 1px 2px rgba(0,0,0,0.8);
  border: 1px solid rgba(255,255,255,0.2);
}

.deck-card-cost.empty {
  min-width: 20px;
}

.deck-card-name {
  flex: 1;
  font-family: 'Cinzel', serif;
  font-size: 0.8rem;
  color: #e8dcc8;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
  min-width: 0;
}

.deck-card-qty {
  display: flex;
  align-items: center;
  gap: 0.3rem;
  flex-shrink: 0;
}

.qty-btn {
  width: 1.4rem;
  height: 1.4rem;
  display: flex;
  align-items: center;
  justify-content: center;
  background: #0d1f12;
  border: 1px solid #2b5035;
  color: #7aaa6a;
  border-radius: 4px;
  font-size: 0.8rem;
  cursor: pointer;
  transition: all 0.1s;
}

.qty-btn:hover {
  background: #1a2e1a;
  border-color: #d4af37;
  color: #f0d878;
}

.qty-value {
  font-family: 'Cinzel', serif;
  font-size: 0.85rem;
  font-weight: 600;
  color: #f0d878;
  min-width: 1.2rem;
  text-align: center;
}
</style>
