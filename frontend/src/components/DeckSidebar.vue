<template>
  <aside class="deck-sidebar">
    <div class="deck-header">
      <h2 class="deck-title">Deck</h2>
    </div>
    <div class="deck-header-line">
      <h2 class="deck-title">Total</h2>
      <span class="deck-count" :class="{ 'deck-full': deckCount < 33 || deckCount > 33 }">
        {{ deckCount }}/60
      </span>
    </div>
    <div class="deck-header-line">
      <h2 class="deck-title">Boss</h2>
      <span class="deck-count" :class="{ 'deck-full': bossCount < 1 || bossCount > 1 }">
        {{ bossCount }}/1
      </span>
    </div>
    <div class="deck-header-line">
      <h2 class="deck-title">Valise</h2>
      <span class="deck-count" :class="{ 'deck-full': valiseCount < 1 || valiseCount > 3 }">
        {{ valiseCount }}/3
      </span>
    </div>
    <div class="deck-header-line">
      <h2 class="deck-title">Action</h2>
      <span class="deck-count" :class="{ 'deck-full': actionCount < 6 }">
        {{ actionCount }}/6+
      </span>
    </div>
    <div class="deck-header-line">
      <h2 class="deck-title">Reaction</h2>
      <span class="deck-count" :class="{ 'deck-full': reactionCount < 6 }">
        {{ reactionCount }}/6+
      </span>
    </div>
    <div class="deck-header-line">
      <h2 class="deck-title">Sbire</h2>
      <span class="deck-count" :class="{ 'deck-full': sbireCount < 8 }">
        {{ sbireCount }}/8+
      </span>
    </div>
    <div class="deck-header-line">
      <h2 class="deck-title">Alliés</h2>
      <span class="deck-count" :class="{ 'deck-full': allieCount < 4 }">
        {{ allieCount }}/4+
      </span>
    </div>

    <div class="deck-header-bottom"></div>

    <ManaCurve :curve="deckByCost" />

    <div class="deck-list">
      <div v-if="deckCards.length === 0" class="deck-empty">
        Click cards to add them to your deck
      </div>

      <DeckCardItem
        v-for="item in deckCards"
        :key="item.card.id"
        :item="item"
      />
    </div>

    <div class="deck-actions">
      <button class="action-btn clear" @click="clearDeck">Clear</button>
      <button class="action-btn export">Export</button>
      <button class="action-btn import">Import</button>
    </div>
  </aside>
</template>

<script setup>
import { deckCards, deckCount, bossCount, valiseCount, actionCount, reactionCount, sbireCount, allieCount, deckByCost, clearDeck } from '../stores/deck.js'
import ManaCurve from './ManaCurve.vue'
import DeckCardItem from './DeckCardItem.vue'
</script>

<style scoped>
.deck-sidebar {
  width: 340px;
  min-width: 340px;
  background: #142414;
  border-left: 1px solid #2b5035;
  display: flex;
  flex-direction: column;
  overflow: hidden;
}

.deck-header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1rem 1.25rem;
}

.deck-header-line {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 0.4rem 1.25rem 0.2rem 1.25rem;
}

.deck-header-bottom {
  padding: 0rem 0rem 0.4rem 0rem;
  border-bottom: 1px solid #2b5035;
}

.deck-title {
  font-family: 'Cinzel', serif;
  font-size: 1.1rem;
  color: #f0d878;
}

.deck-count {
  font-family: 'Cinzel', serif;
  font-size: 0.85rem;
  font-weight: 700;
  color: #d4af37;
  background: #1a2e1a;
  padding: 0.3rem 0.7rem;
  border-radius: 6px;
  border: 1px solid #2b5035;
}

.deck-full {
  color: #fd4141;
  background: #ff000046;
  border-color: #e85757;
}

.deck-list {
  flex: 1;
  overflow-y: auto;
  padding: 0.5rem 0;
}

.deck-empty {
  padding: 2rem 1.25rem;
  text-align: center;
  color: #3a6b45;
  font-size: 0.9rem;
  font-style: italic;
}

.deck-actions {
  display: flex;
  gap: 0.5rem;
  padding: 0.75rem 1.25rem;
  border-top: 1px solid #2b5035;
}

.action-btn {
  flex: 1;
  padding: 0.6rem;
  border-radius: 8px;
  border: 1px solid #2b5035;
  background: #1a2e1a;
  color: #c8d8a8;
  font-family: 'Cinzel', serif;
  font-size: 0.8rem;
  font-weight: 600;
  cursor: pointer;
  transition: all 0.15s;
  text-transform: uppercase;
  letter-spacing: 0.05em;
}

.action-btn:hover {
  background: #1f3a1f;
  border-color: #d4af37;
}

.action-btn.clear {
  color: #ff5252;
}

.action-btn.export {
  color: #d0a107;
}

.action-btn.import {
  color: #d0a107;
}
</style>
