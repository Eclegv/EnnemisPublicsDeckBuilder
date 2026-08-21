import { reactive, computed } from 'vue'
import { getCardSets, getCardsBySet } from '../api/client.js'

export const TOKENS = ['Solidity', 'Obscurantism', 'Notoriety', 'Idea', 'Violence']

export const COLORS = {
  Solidity: '#8B4513',
  Obscurantism: '#4B0082',
  Notoriety: '#B22222',
  Idea: '#FFD700',
  Violence: '#8B0000'
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
    const idxA = TOKENS.indexOf(a.card.name)
    const idxB = TOKENS.indexOf(b.card.name)
    if (idxA !== idxB) return idxA - idxB
    return a.card.name.localeCompare(b.card.name)
  })
})

export const errors = computed(() => {
  let errorsData = {
    count: 0,
    text: ""
  }

  if(deckCount.value != 33)
  {
    errorsData.count++
    errorsData.text = `${errorsData.text}- Le total de carte est ${deckCount > 33 ? "superieur" : "inferieur"} a la taille attendu du deck : 33\n`
  }

  if(bossCount.value != 1)
  {
    errorsData.count++
    errorsData.text = `${errorsData.text}- Le nombre de boss est ${deckCount > 1 ? "superieur" : "inferieur"} a la valeur attendue : 1\n`
  }

  if(valiseCount.value != 3)
  {
    errorsData.count++
    errorsData.text = `${errorsData.text}- Le nombre de valise est ${deckCount > 3 ? "superieur" : "inferieur"} a la valeur attendue : 3\n`
  }

  if(actionCount.value < 6)
  {
    errorsData.count++
    errorsData.text = `${errorsData.text}- Le nombre d'action est inferieur a la valeur attendue : 6\n`
  }

  if(sbireCount.value < 8)
  {
    errorsData.count++
    errorsData.text = `${errorsData.text}- Le nombre de sbire est inferieur a la valeur attendue : 8\n`
  }

  if(allieCount.value < 4)
  {
    errorsData.count++
    errorsData.text = `${errorsData.text}- Le nombre d'alliés est inferieur a la valeur attendue : 4\n`
  }

  deckCards.value.forEach(element => {
    if((element.card.type == "Allie" || element.card.type == "Eclipse") && element.count > 1)
    {
      errorsData.count++
      errorsData.text = `${errorsData.text}- La carte ${element.card.type} ${element.card.name} est presente en plus d'un exemplaire\n`
    }
    if((element.card.type == "SbireUnique") && element.count > 1)
    {
      errorsData.count++
      errorsData.text = `${errorsData.text}- La carte ${element.card.type} ${element.card.name} est presente en plus d'un exemplaire\n`
    }
    if(element.card.type == "Eclipse")
    {
       deckCards.value.forEach(card => {
        if (element.card.eclipseEffect == card.card.name)
        {
          errorsData.count++
          errorsData.text = `${errorsData.text}- La carte ${element.card.type} ${element.card.name} a son Eclipse ${card.card.name} presente dans le deck\n`
        }
      });
    }
  });

  return errorsData
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
  countType(["Action", "Reaction"])
)

function countType(cardTOKENS)
{
  return deckCards.value.reduce((sum, item) => {
    if(cardTOKENS.includes(item.card.type))
      return sum + item.count
    else
      return sum
  }, 0)
}

export const deckByCost = computed(() => {
  const dist = {}
  for (const t of TOKENS) dist[t] = 0

  for (const item of deckCards.value) {
    const costs = item.card.costs
    if (costs) {
      costs.forEach(element => {
        dist[element.name] += item.count
      });
    }
  }
  return dist
})

export const deckByValue = computed(() => {
  const dist = {}
  for (const t of TOKENS) dist[t] = 0

  for (const item of deckCards.value) {
    const values = item.card.values
    if (values) {
      values.forEach(element => {
        dist[element.name] += item.count
      });
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
      const cards = data.sort((a, b) => a.type.localeCompare(b.type))
      state.cardsBySet[guid] = Array.isArray(cards) ? cards : []
    })
  } catch (err) {
    state.error = 'Failed to load some cards.'
    console.error(err)
  } finally {
    state.loadingCards = false
  }
}
