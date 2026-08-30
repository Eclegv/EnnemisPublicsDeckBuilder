<template>
  <div class="sidebar-wrapper">
    <button class="burger-btn" @click="isCollapsed = !isCollapsed" title="Open deck">
      <span class="burger-icon">☰</span>
      <span :data-warning="deckCount != 33" class="burger-count">{{ deckCount }}</span>
    </button>

    <aside class="deck-sidebar" :class="{ collapsed: isCollapsed }">
      <div class="deck-list-header">
        <Divider />
        <span> Total {{ deckCount }}/33</span>
        <Divider />
        <ErrorButton :errors="errors.errorsByGroup['Deck']"></ErrorButton>
      </div>
      <div class="deck-list">
        <div>
          <DeckSection
            :type="['Boss']"
            :upperlimit="1"
            :strictlimit="true"
            :cardCount="bossCount"
            :errors="errors.errorsByGroup['Boss']"
          />
          <DeckSection
            :type="['Valise']"
            :upperlimit="3"
            :strictlimit="true"
            :cardCount="valiseCount"
            :errors="errors.errorsByGroup['Valise']"
          />
          <DeckSection
            :type="['Action', 'Reaction']"
            :upperlimit="6"
            :strictlimit="false"
            :cardCount="actionCount"
            :errors="errors.errorsByGroup['Action']"
          />
          <DeckSection
            :type="['Sbire', 'SbireUnique']"
            :upperlimit="8"
            :strictlimit="false"
            :cardCount="sbireCount"
            :errors="errors.errorsByGroup['Sbire']"
          />
          <DeckSection
            :type="['Allie', 'Eclipse']"
            :upperlimit="4"
            :strictlimit="false"
            :cardCount="allieCount"
            :errors="errors.errorsByGroup['Allie']"
          />
        </div>
      </div>

      <ManaCurve :costs="deckByCost" :values="deckByValue" />

      <div class="deck-actions">
        <button class="action-btn clear" @click="clearDeck">Effacer</button>
        <button class="disabled import">Importer</button>
        <button class="disabled export">Exporter</button>
      </div>
    </aside>
  </div>
</template>

<script setup>
import {
  deckCards,
  deckCount,
  bossCount,
  valiseCount,
  actionCount,
  sbireCount,
  allieCount,
  deckByCost,
  deckByValue,
  clearDeck,
  errors,
  getDeckCardsByType,
  isMobile,
} from "../stores/deck.js";
import ManaCurve from "./ManaCurve.vue";
import DeckCardItem from "./DeckCardItem.vue";
import DeckSection from "./DeckSection.vue";
import ErrorButton from "./ErrorButton.vue";
import Divider from "./Divider.vue";
import { ref } from "vue";

const isCollapsed = ref(false || isMobile());
</script>

<style scoped>
.sidebar-wrapper {
  position: relative;
  display: flex;
  flex-shrink: 0;
  width: 340px;
  transition: width 0.25s ease;
}

@media (max-width: 768px) {
  .sidebar-wrapper {
    position: fixed;
    right: 0;
    top: 0;
    bottom: 0;
  }
}

.sidebar-wrapper:has(.deck-sidebar.collapsed) {
  width: 0;
}

.sidebar-wrapper:has(.deck-sidebar.collapsed) .burger-btn {
  transform: translate(-100%, -100%);
}

.deck-list-header {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.burger-btn {
  position: absolute;
  left: 0;
  top: 50%;
  transform: translate(-100%, -100%);
  z-index: 100;

  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 0.25rem;

  padding: 0.6rem 0.4rem;
  background: #142414;
  border: 1px solid #2b5035;
  border-right: none;
  border-radius: 8px 0 0 8px;
  cursor: pointer;

  transition: all 0.2s ease;
  box-shadow: -2px 0 10px rgba(0, 0, 0, 0.4);
}

.burger-btn:hover {
  background: #1a2e1a;
  border-color: #d4af37;
}

.burger-icon {
  font-size: 1.1rem;
  color: #d4af37;
}

.burger-count {
  font-family: "Cinzel", serif;
  font-size: 0.75rem;
  font-weight: 700;
  color: #f0d878;
  background: #0d1f12;
  padding: 0.1rem 0.35rem;
  border-radius: 4px;
  border: 1px solid #2b5035;

  &[data-warning="true"] {
    color: #cc4545;
  }
}

.deck-sidebar.collapsed {
  transform: translateX(100%);
  opacity: 0;
  pointer-events: none;
}

.deck-sidebar {
  width: 340px;
  min-width: 340px;
  background: #142414;
  border-left: 1px solid #2b5035;
  display: flex;
  flex-direction: column;
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
  font-family: "Cinzel", serif;
  font-size: 1.1rem;
  color: #f0d878;
}

.deck-count {
  font-family: "Cinzel", serif;
  font-size: 0.85rem;
  font-weight: 700;
  color: #d4af37;
  background: #1a2e1a;
  padding: 0.3rem 0.7rem;
  width: 3rem;
  text-align: center;
  border-radius: 6px;
  border: 1px solid #2b5035;
}

.deck-full {
  color: #fd4141;
}

.deck-list {
  flex: 1;
  overflow-y: auto;
  padding: 0.5rem 0;
}

.deck-empty {
  padding: 2rem 1.25rem;
  text-align: center;
  color: #abcea0b3;
  font-size: 0.95rem;
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
  font-family: "Cinzel", serif;
  font-size: 0.8rem;
  font-weight: 600;
  cursor: pointer;
  transition: all 0.15s;
  text-transform: uppercase;
  letter-spacing: 0.05em;
}

.disabled {
  flex: 1;
  padding: 0.6rem;
  border-radius: 8px;
  border: 1px solid #2b5035;
  color: #5c5151;
  font-family: "Cinzel", serif;
  font-size: 0.8rem;
  font-weight: 600;
  cursor: default;
  background: #0a0b0a;
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
