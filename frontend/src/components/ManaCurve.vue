<template>
  <Distribution :title="`Symboles consommés`" :curve="costs"></Distribution>
  <Distribution :title="`Symboles générés`" :curve="values"></Distribution>
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
