<template>
  <div class="type-filter">
    <div class="type-checkboxes">
      <label
        v-for="type in TYPES"
        :key="type"
        class="type-checkbox"
        :class="{ checked: modelValue.includes(type) }"
      >
        <input
          type="checkbox"
          :value="type"
          :checked="modelValue.includes(type)"
          @change="toggle(type)"
        />
        <span class="type-name">{{ type }}</span>
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

function toggle(type) {
  const idx = props.modelValue.indexOf(type)
  console.log(idx)
  if (idx >= 0) {
    props.modelValue.splice(idx, 1)
  } else {
    props.modelValue.push(type)
  }
  console.log(props.modelValue)
}
</script>

<style scoped>
.type-filter {
  padding: 0.75rem 1.25rem;
  background: #142414;
}

.type-filter-label {
  font-family: 'Cinzel', serif;
  font-size: 0.7rem;
  font-weight: 600;
  color: #7aaa6a;
  text-transform: uppercase;
  letter-spacing: 0.08em;
  margin-bottom: 0.6rem;
}

.type-checkboxes {
  display: flex;
  gap: 0.5rem;
  flex-wrap: wrap;
}

.type-checkbox {
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

.type-checkbox:hover {
  border-color: #d4af37;
  background: #558963;
}

.type-checkbox.checked {
  background: #1f3a1f;
  border-color: #d4af37;
  box-shadow: 0 0 8px rgba(212, 175, 55, 0.15);
}

.type-checkbox input {
  display: none;
}

.type-swatch {
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

.type-name {
  font-family: 'Crimson Text', serif;
  font-size: 0.8rem;
  color: #c8d8a8;
}

.type-checkbox.checked .type-name {
  color: #f0d878;
}
</style>