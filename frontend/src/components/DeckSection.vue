<template>
  <div class="card-section">
    <div class="deck-section-header-line">
      <button class="collapse-section-btn" @click="isCollapsed = !isCollapsed">
        <span v-if="isCollapsed" class="collapse-section-icon material-symbols-outlined">
          arrow_right
        </span>
        <span v-else class="collapse-section-icon material-symbols-outlined">
          arrow_drop_down
        </span>
      </button>
      <h2 class="deck-section-title">{{ type[0] }}</h2>
      <Divider />
      <span> {{ cardCount }}/{{ `${upperlimit}${strictlimit ? "" : "+"}` }} </span>
      <ErrorButton :errors="errors"></ErrorButton>
    </div>
    <div class="cards-zone" :class="{ collapsed: isCollapsed }">
      <DeckCardItem
        v-for="item in getDeckCardsByType(props.type)"
        :key="item.card.id"
        :item="item"
      />
    </div>
  </div>
</template>

<script setup>
import { ref } from "vue";
import { getDeckCardsByType } from "../stores/deck.js";
import DeckCardItem from "./DeckCardItem.vue";
import ErrorButton from "./ErrorButton.vue";
import Divider from "./Divider.vue";

const props = defineProps({
  type: {
    type: Array,
    default: [],
  },
  upperlimit: {
    type: Number,
    default: 0,
  },
  strictlimit: {
    type: Boolean,
    default: true,
  },
  cardCount: {
    type: Number,
    default: 0,
  },
  errors: {
    type: String,
    default: "",
  },
});

let isCollapsed = ref(false);
</script>

<style scoped>
.material-symbols-outlined {
  font-variation-settings: "FILL" 0, "wght" 400, "GRAD" 0, "opsz" 24;
}

.cards-zone:has(.collapsed) {
  width: 0;
}

.cards-zone.collapsed {
  max-height: 0;
  opacity: 0;
  pointer-events: none;
}

.deck-section-header-line {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 0.4rem 0rem 0.2rem 0rem;
}

.card-section {
}

.deck-section-title {
  font-family: "Cinzel", serif;
  font-size: 1.1rem;
  color: #68826b;
}

.collapse-section-btn {
  font-size: 1rem;

  border: 0;
  background: none;
  box-shadow: none;
  border-radius: 0px;
  cursor: pointer;

  transition: all 0.2s ease;
}

.collapse-section-btn:hover {
  background: #1a2e1a;
  border-color: #d4af37;
}

.collapse-section-icon {
  font-size: 1.1rem;
  color: #d4af37;
}
</style>
