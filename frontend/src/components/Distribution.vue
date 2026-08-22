<template>
  <div class="cost-dist">
    <div class="dist-title">{{ title }}</div>
    <div class="dist-bars">
      <div
        v-for="token in TOKENS"
        :key="token"
        class="dist-bar-wrap"
      >
        <div class="dist-value">{{ curve[token] || 0 }}</div>
        <div class="dist-bar-bg">
          <div
            class="dist-bar-fill"
            :style="{ height: barHeight(token) + '%', background: tokenColor(token) }"
          />
        </div>
        <div class="dist-label">{{ token }}</div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { computed } from 'vue'
import { TOKENS, COLORS } from '../stores/deck.js'

const props = defineProps({
  title: {
    type: String,
    default: ""
  },
  curve: {
    type: Object,
    default: () => ({})
  }
})

const maxVal = computed(() => {
  const vals = Object.values(props.curve)
  return vals.length > 0 ? Math.max(...vals, 1) : 1
})

function barHeight(token) {
  const val = props.curve[token] || 0
  return (val / maxVal.value) * 100
}

function tokenColor(token) {
  return COLORS[token] || '#666'
}

</script>

<style scoped>
.cost-dist {
  padding: 0.75rem 1.25rem;
  border-bottom: 1px solid #2b5035;
}

.dist-title {
  font-family: 'Cinzel', serif;
  font-size: 0.7rem;
  font-weight: 600;
  color: #abcea0;
  text-transform: uppercase;
  letter-spacing: 0.08em;
  margin-bottom: 0.8rem;
}

.dist-bars {
  display: flex;
  align-items: flex-end;
  gap: 0.5rem;
}

.dist-bar-wrap {
  flex: 1;
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 0.25rem;
}

.dist-value {
  font-size: 0.75rem;
  font-weight: 600;
  color: #d4af37;
  min-height: 16px;
}

.dist-bar-bg {
  width: 100%;
  height: 50px;
  background: #1a2e1a;
  border-radius: 4px;
  display: flex;
  align-items: flex-end;
  overflow: hidden;
  border: 1px solid #2b5035;
}

.dist-bar-fill {
  width: 100%;
  border-radius: 4px 4px 0 0;
  transition: height 0.3s ease;
  min-height: 2px;
}

.dist-label {
  font-size: 0.8rem;
  color: #abcea0;
  text-align: center;
}
</style>