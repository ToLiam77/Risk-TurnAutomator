# 🎲 Risk Battle API

A simple ASP.NET Core Minimal API that simulates battles in the board game Risk.

## How It Works
Send a `GET` request to the `/battle` endpoint with the number of attacking and defending troops.

### Example Request:
`https://localhost:<PORT>/battle?attTroops=6&defTroops=7`

Replace `<PORT>` with the actual port your API runs on.

### Example Response:
```{
  {
  "initialAttackers": 6,
  "initialDefenders": 7,
  "remainingAttackers": 1,
  "remainingDefenders": 2,
  "winner": "Defenders",
  "rounds": [
    {
      "round": 1,
      "attackerRolls": [6, 6, 3],
      "defenderRolls": [4, 1],
      "remainingAttackers": 6,
      "remainingDefenders": 5
    },
    {
      "round": 2,
      "attackerRolls": [6, 4, 2],
      "defenderRolls": [5, 4],
      "remainingAttackers": 5,
      "remainingDefenders": 4
    },
    {
      "round": 3,
      "attackerRolls": [3, 2, 1],
      "defenderRolls": [5, 3],
      "remainingAttackers": 3,
      "remainingDefenders": 4
    },
    {
      "round": 4,
      "attackerRolls": [6, 4],
      "defenderRolls": [4, 2],
      "remainingAttackers": 3,
      "remainingDefenders": 2
    },
    {
      "round": 5,
      "attackerRolls": [4, 2],
      "defenderRolls": [5, 4],
      "remainingAttackers": 1,
      "remainingDefenders": 2
    }
  ]
}
