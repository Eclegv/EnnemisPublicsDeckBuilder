<template>
  <div class="card-wrapper" @click="$emit('add')">
    <div class="card-outer" :class="cardBorderClass">
      <div class="card-inner">
        <!-- Portrait image -->
        <div class="card-portrait">
          <img v-if="card.id" :src="`/src/assets/img/${card.id}.png`" :alt="card.name" />
          <div v-else class="portrait-placeholder">
            <span>{{ card.name?.[0] || '◈' }}</span>
          </div>
        </div>

        <!-- Name with decorative lines -->
        <div class="card-namebar">
          <span class="name-line left">◆</span>
          <span class="card-name">{{ card.name }}</span>
          <span class="name-line right">◆</span>
        </div>

        <!-- Text box -->
        <div class="card-textbox">
          <div v-if="card.type" class="card-type">{{ card.type }}</div>
          <div v-if="card.description" class="card-description">
            {{ card.description }}
          </div>
          <div v-if="card.flavor" class="card-flavor">"{{ card.flavor }}"</div>
        </div>
      </div>
    </div>

    <!-- Hover overlay -->
    <div class="card-overlay">
      <button class="add-btn" @click.stop="$emit('add')">+ Add to Deck</button>
    </div>
  </div>
</template>

<script setup>
import { computed } from 'vue'
import { COLORS } from '../stores/deck.js'

const props = defineProps({
  card: {
    type: Object,
    required: true
  }
})

defineEmits(['add'])

const isLeader = computed(() => {
  const t = (props.card.type || '').toLowerCase()
  return t.includes('leader') || t.includes('commander') || props.card.isLeader
})

const cardBorderClass = computed(() => {
  return isLeader.value ? 'border-leader' : 'border-regular'
})

function costColor(cost) {
  return COLORS[cost] || '#666'
}
</script>

<style scoped>
.card-wrapper {
  position: relative;
  cursor: pointer;
  transition: transform 0.25s ease;
}

.card-wrapper:hover {
  transform: translateY(-6px) scale(1.02);
}

.card-wrapper:hover .card-overlay {
  opacity: 1;
}

.card-outer {
  border-radius: 14px;
  padding: 4px;
  background: linear-gradient(145deg, #2b5035, #1a3a1f, #2b5035);
  box-shadow: 0 4px 20px rgba(0,0,0,0.6), inset 0 1px 0 rgba(255,255,255,0.1);
}

.border-leader {
  background: linear-gradient(145deg, #b22222, #8b0000, #b22222);
  box-shadow: 0 4px 20px rgba(139, 0, 0, 0.4), inset 0 1px 0 rgba(255,255,255,0.1);
}

.border-regular {
  background: #b49415;
}

.card-inner {
  position: relative;
  background: #0d1f12;
  border-radius: 11px;
  overflow: hidden;
  display: flex;
  flex-direction: column;
  height: 100%;
  min-height: 380px;
}

.cost-icons {
  position: absolute;
  top: 8px;
  left: 8px;
  z-index: 3;
  display: flex;
  flex-direction: column;
  gap: 3px;
}

.cost-icon {
  width: 22px;
  height: 22px;
  border-radius: 4px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 0.65rem;
  font-weight: 700;
  color: #fff;
  text-shadow: 0 1px 2px rgba(0,0,0,0.8);
  border: 1px solid rgba(255,255,255,0.3);
  box-shadow: 0 2px 4px rgba(0,0,0,0.4);
}

.card-portrait {
  position: relative;
  aspect-ratio: 3/4;
  overflow: hidden;
  background: #1a2e1a;
}

.card-portrait::after {
  content: '';
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  height: 40px;
  background: linear-gradient(to top, #0d1f12, transparent);
}

.card-portrait img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.portrait-placeholder {
  width: 100%;
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 4rem;
  color: #2b5035;
  font-family: 'Cinzel', serif;
}

.card-namebar {
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 0.5rem;
  padding: 0.5rem 0.75rem;
  background: #0d1f12;
  border-top: 1px solid #2b5035;
  border-bottom: 1px solid #2b5035;
}

.name-line {
  color: #d4af37;
  font-size: 0.6rem;
}

.card-name {
  font-family: 'Cinzel', serif;
  font-size: 0.9rem;
  font-weight: 700;
  color: #f0d878;
  text-align: center;
  letter-spacing: 0.05em;
  text-transform: uppercase;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}

.card-textbox {
  flex: 1;
  padding: 0.75rem;
  background: #0d1f12;
  display: flex;
  flex-direction: column;
  gap: 0.5rem;
}

.card-type {
  font-size: 0.7rem;
  color: #7aaa6a;
  text-transform: uppercase;
  letter-spacing: 0.1em;
  text-align: center;
  border-bottom: 1px solid #2b5035;
  padding-bottom: 0.4rem;
}

.card-description {
  font-size: 0.8rem;
  color: #d8dcc8;
  line-height: 1.5;
  flex: 1;
}

.card-flavor {
  font-size: 0.75rem;
  color: #6a8a5a;
  font-style: italic;
  text-align: center;
  padding-top: 0.25rem;
  border-top: 1px solid #1a2e1a;
}

.card-overlay {
  position: absolute;
  inset: 0;
  display: flex;
  align-items: center;
  justify-content: center;
  background: rgba(13, 31, 18, 0.75);
  opacity: 0;
  transition: opacity 0.2s ease;
  border-radius: 14px;
}

.add-btn {
  background: #d4af37;
  color: #0d1f12;
  border: none;
  padding: 0.7rem 1.8rem;
  border-radius: 8px;
  font-family: 'Cinzel', serif;
  font-size: 0.9rem;
  font-weight: 700;
  cursor: pointer;
  transition: all 0.15s;
  box-shadow: 0 4px 15px rgba(212, 175, 55, 0.3);
}

.add-btn:hover {
  background: #f0d878;
  transform: scale(1.05);
}
</style>
