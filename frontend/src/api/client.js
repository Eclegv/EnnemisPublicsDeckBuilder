const API_BASE = import.meta.env.VITE_BACKEND_URL

async function request(url, method) {
  const response = await fetch(`${API_BASE || '/api'}${url}`, {
    method: method
  })
  if (!response.ok) {
    throw new Error(`HTTP error! status: ${response.status}`)
  }
  return response.json()
}

export function getCardSets() {
  return request('/cardset', "GET")
}

export function getCardsBySet(guid) {
  return request(`/cardset/${guid}/cards`, "GET")
}
