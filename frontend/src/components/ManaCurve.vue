<template>
  <Distribution :title="`Cost Distribution`" :curve="costs"></Distribution>
  <Distribution :title="`Value Distribution`" :curve="values"></Distribution>
</template>

<script setup>
import { computed } from 'vue'
import Distribution from './Distribution.vue'

const props = defineProps({
  costs: {
    type: Object,
    default: () => ({})
  },
  values: {
    type: Object,
    default: () => ({})
  }
})
</script>
