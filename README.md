# 🎲 Risk Battle API

A simple ASP.NET Core Minimal API that simulates battles in the board game Risk.

## How It Works
Send a `GET` request to the `/battle` endpoint with the number of attacking and defending troops.

### Example Request:
`https://localhost:7262/battle?attTroops=5&defTroops=5`

Replace `<PORT>` with the actual port your API runs on.

### Example Response:
```{
  "initialAttackers": 5,
  "initialDefenders": 5,
  "remainingAttackers": 1,
  "remainingDefenders": 4,
  "winner": "Defenders",
  "rounds": [
    {
      "attackerRolls": [5, 1, 1],
      "defenderRolls": [3, 1]
    },
    {
      "attackerRolls": [6, 3, 2],
      "defenderRolls": [6, 4]
    },
    {
      "attackerRolls": [4],
      "defenderRolls": [6,3]
    }
  ]
}
