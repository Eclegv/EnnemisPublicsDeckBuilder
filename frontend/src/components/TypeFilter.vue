<template>
  <div class="cost-filter">
    <div class="cost-checkboxes">
      <label
        v-for="type in TYPES"
        :key="type"
        class="cost-checkbox"
        :class="{ checked: modelValue.includes(type) }"
      >
        <input
          type="checkbox"
          :value="type"
          :checked="modelValue.includes(type)"
          @change="toggle(type)"
        />
        <span class="cost-name">{{ type }}</span>
      </label>
    </div>
  </div>
</template>

<script setup>
import { TYPES, COLORS } from '../stores/deck.js'

const props = defineProps({
  modelValue: {
    type: Array,
    default: () => []
  }
})

const emit = defineEmits(['update:modelValue'])

function toggle(cost) {
  const idx = props.modelValue.indexOf(cost)
  console.log(idx)
  if (idx >= 0) {
    props.modelValue.splice(idx, 1)
  } else {
    props.modelValue.push(cost)
  }
  console.log(props.modelValue)
}
</script>

<style scoped>
.cost-filter {
  padding: 0.75rem 1.25rem;
  background: #142414;
}

.cost-filter-label {
  font-family: 'Cinzel', serif;
  font-size: 0.7rem;
  font-weight: 600;
  color: #7aaa6a;
  text-transform: uppercase;
  letter-spacing: 0.08em;
  margin-bottom: 0.6rem;
}

.cost-checkboxes {
  display: flex;
  gap: 0.5rem;
  flex-wrap: wrap;
}

.cost-checkbox {
  display: flex;
  align-items: center;
  gap: 0.4rem;
  padding: 0.35rem 0.7rem;
  background: #1a2e1a;
  border: 1px solid #2b5035;
  border-radius: 8px;
  cursor: pointer;
  transition: all 0.15s ease;
  user-select: none;
}

.cost-checkbox:hover {
  border-color: #4a7a55;
}

.cost-checkbox.checked {
  background: #1f3a1f;
  border-color: #d4af37;
  box-shadow: 0 0 8px rgba(212, 175, 55, 0.15);
}

.cost-checkbox input {
  display: none;
}

.cost-swatch {
  width: 18px;
  height: 18px;
  border-radius: 4px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 0.6rem;
  font-weight: 700;
  color: #fff;
  text-shadow: 0 1px 2px rgba(0, 0, 0, 0.8);
  border: 1px solid rgba(255, 255, 255, 0.2);
  flex-shrink: 0;
}

.cost-name {
  font-family: 'Crimson Text', serif;
  font-size: 0.8rem;
  color: #c8d8a8;
}

.cost-checkbox.checked .cost-name {
  color: #f0d878;
}
</style>