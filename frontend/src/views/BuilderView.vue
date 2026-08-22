<template>
  <div class="builder">
    <SetFilterBar />

    <div class="builder-body">
      <div class="card-area">
        <div class="search-bar">
          <input
            type="text"
            placeholder="Search cards..."
            :value="searchQuery"
            @input="e => setSearchQuery(e.target.value)"
          />
          <span class="result-count">{{ filteredCardsByType.length }} cards</span>
          <TypeFilter :modelValue="filteredCardTypes"></TypeFilter>
        </div>

        <div v-if="loading && filteredCards.length === 0" class="status">
          Loading cards...
        </div>
        <div v-else-if="error" class="status error">{{ error }}</div>
        <div v-else-if="filteredCards.length === 0" class="status">
          No cards found. Select a card set above.
        </div>

        <CardGrid v-else :cards="filteredCardsByType" />
      </div>

      <DeckSidebar />
    </div>
  </div>
</template>

<script setup>
import { onMounted } from 'vue'
import { loadSets, searchQuery, filteredCardsByType, filteredCardTypes, filteredCards, loading, error, setSearchQuery } from '../stores/deck.js'
import SetFilterBar from '../components/SetFilterBar.vue'
import CardGrid from '../components/CardGrid.vue'
import DeckSidebar from '../components/DeckSidebar.vue'
import TypeFilter from '../components/TypeFilter.vue'

onMounted(loadSets)
</script>

<style scoped>
.builder {
  display: flex;
  flex-direction: column;
  height: 100vh;
  overflow: hidden;
}

.builder-body {
  display: flex;
  flex: 1;
  overflow: hidden;
}

.card-area {
  flex: 1;
  display: flex;
  flex-direction: column;
  overflow: hidden;
  min-width: 0;
}

.search-bar {
  display: flex;
  align-items: center;
  padding: 0.75rem 1rem;
  border-bottom: 1px solid #2b5035;
  background: #142414;
}

.search-bar input {
  flex: 1;
  background: #1a2e1a;
  border: 1px solid #2b5035;
  border-radius: 8px;
  padding: 0.5rem 1rem;
  color: #e8dcc8;
  font-family: 'Crimson Text', serif;
  font-size: 0.95rem;
  outline: none;
  transition: border-color 0.2s;
}

.search-bar input:focus {
  border-color: #d4af37;
}

.search-bar input::placeholder {
  color: #4a7a55;
}

.result-count {
  font-size: 0.85rem;
  padding: 0rem 0rem 0rem 0.5rem;
  color: #c8d8a8;
  white-space: nowrap;
}

.status {
  flex: 1;
  display: flex;
  align-items: center;
  justify-content: center;
  color: #4a7a55;
  font-size: 1.1rem;
}

.error {
  color: #c44;
}
</style>
