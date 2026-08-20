const API_BASE = 'http://127.0.0.1:5245/api'

async function request(url, method) {
  const response = await fetch(`${API_BASE}${url}`, {
    method: method
  })
  if (!response.ok) {
    throw new Error(`HTTP error! status: ${response.status}`)
  }
  return response.json()
}

export function getCardSets() {
  return request('/cardset/', "GET")
}

export function getCardsBySet(guid) {
  return request(`/cardset/${guid}/cards`, "GET")
}
