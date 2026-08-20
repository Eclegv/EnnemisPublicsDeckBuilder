import { reactive, computed } from 'vue'
import { getCardSets, getCardsBySet } from '../api/client.js'

export const TYPES = ['Solidity', 'Obscurantism', 'Notoriety', 'Idea', 'Violence']

export const COLORS = {
  Solidity: '#8B4513',
  Obscurantism: '#4B0082',
  Notoriety: '#B22222',
  Idea: '#FFD700',
  Violence: '#8B0000'
}

export const ICONS = {
  Solidity: 'S',
  Obscurantism: 'O',
  Notoriety: 'N',
  Idea: 'I',
  Violence: 'V'
}

const state = reactive({
  sets: [],
  cardsBySet: {},
  selectedSetGuids: [],
  deck: {},
  searchQuery: '',
  loadingSets: false,
  loadingCards: false,
  error: null
})

export const sets = computed(() => state.sets)
export const selectedSetGuids = computed(() => state.selectedSetGuids)
export const searchQuery = computed(() => state.searchQuery)
export const loading = computed(() => state.loadingSets || state.loadingCards)
export const error = computed(() => state.error)

export const allCards = computed(() => {
  const cards = []
  for (const guid of state.selectedSetGuids) {
    if (state.cardsBySet[guid]) {
      cards.push(...state.cardsBySet[guid])
    }
  }
  return cards
})

export const filteredCards = computed(() => {
  const q = state.searchQuery.toLowerCase().trim()
  if (!q) return allCards.value
  return allCards.value.filter(c =>
    c.name?.toLowerCase().includes(q) ||
    c.type?.toLowerCase().includes(q)
  )
})

export const deckCards = computed(() => {
  return Object.values(state.deck).sort((a, b) => {
    const idxA = TYPES.indexOf(a.card.name)
    const idxB = TYPES.indexOf(b.card.name)
    if (idxA !== idxB) return idxA - idxB
    return a.card.name.localeCompare(b.card.name)
  })
})

export const deckCount = computed(() =>
  deckCards.value.reduce((sum, item) => sum + item.count, 0)
)

export const bossCount = computed(() =>
  countType(["Boss"])
)

export const allieCount = computed(() =>
  countType(["Allie", "Eclipse"])
)

export const sbireCount = computed(() =>
  countType(["Sbire", "SbireUnique"])
)

export const valiseCount = computed(() =>
  countType(["Valise"])
)

export const actionCount = computed(() =>
  countType(["Action"])
)
export const reactionCount = computed(() =>
  countType(["Reaction"])
)

function countType(cardTypes)
{
  return deckCards.value.reduce((sum, item) => {
    if(cardTypes.includes(item.card.type))
      return sum + item.count
    else
      return sum
  }, 0)
}

export const deckByCost = computed(() => {
  const dist = {}
  for (const t of TYPES) dist[t] = 0

  for (const item of deckCards.value) {
    const cost = item.card.cost
    if (cost && dist[cost] !== undefined) {
      dist[cost] += item.count
    }
  }
  return dist
})

export const deckByValue = computed(() => {
  const dist = {}
  for (const t of TYPES) dist[t] = 0

  for (const item of deckCards.value) {
    const value = item.card.value
    if (cost && dist[value] !== undefined) {
      dist[value] += item.count
    }
  }
  return dist
})

export function isSetSelected(guid) {
  return state.selectedSetGuids.includes(guid)
}

export function toggleSet(guid) {
  const idx = state.selectedSetGuids.indexOf(guid)
  if (idx >= 0) {
    state.selectedSetGuids.splice(idx, 1)
  } else {
    state.selectedSetGuids.push(guid)
  }
}

export function setSearchQuery(q) {
  state.searchQuery = q
}

export function addToDeck(card) {
  const id = card.id
  if (state.deck[id]) {
    state.deck[id].count++
  } else {
    state.deck[id] = { card, count: 1 }
  }
}

export function removeFromDeck(card) {
  const id = card.id
  if (state.deck[id]) {
    state.deck[id].count--
    if (state.deck[id].count <= 0) {
      delete state.deck[id]
    }
  }
}

export function removeAllFromDeck(card) {
  const id = card.id
  delete state.deck[id]
}

export function clearDeck() {
  state.deck = {}
}

export async function loadSets() {
  state.loadingSets = true
  state.error = null
  try {
    const data = await getCardSets()
    state.sets = Array.isArray(data) ? data : []
    state.selectedSetGuids = state.sets.map(s => s.id)
    await loadCardsForSelected()
  } catch (err) {
    state.error = 'Failed to load card sets.'
    console.error(err)
  } finally {
    state.loadingSets = false
  }
}

export async function loadCardsForSelected() {
  const toFetch = state.selectedSetGuids.filter(g => !state.cardsBySet[g])
  if (toFetch.length === 0) return
  state.loadingCards = true
  try {
    const results = await Promise.all(
      toFetch.map(guid => getCardsBySet(guid))
    )
    results.forEach((data, i) => {
      const guid = toFetch[i]
      const cards = data
      state.cardsBySet[guid] = Array.isArray(cards) ? cards : []
    })
  } catch (err) {
    state.error = 'Failed to load some cards.'
    console.error(err)
  } finally {
    state.loadingCards = false
  }
}
