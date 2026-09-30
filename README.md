# RS3 Zamorak Bad Luck Mitigation  Calculator

A small **.NET 10 console application** for calculating the rare-drop rate of **Zamorak, Lord of Chaos** in RuneScape 3.

The project is being developed as a standalone calculator to validate the **Bad Luck Mitigation (BLM)** mechanics before eventually being adapted into an in-game **Lua plugin** using live game data.

## BLM Rules

Only kills at **100%+ enrage** contribute toward BLM.

* Story Mode and Normal Mode do not count.
* The first **10 eligible kills** do not increase the BLM rate.
* After 10 eligible kills, the drop-rate denominator decreases according to the enrage bracket.
* The rate cannot exceed the maximum chance for that bracket.

## Enrage Brackets

|       Enrage | Decrement | Base Chance | Maximum Chance |
| -----------: | --------: | ----------: | -------------: |
|     100–149% |         1 |        1/80 |           1/20 |
|     150–199% |         1 |        1/77 |           1/20 |
|     200–299% |         1 |        1/72 |           1/20 |
|     300–399% |         1 |        1/67 |           1/20 |
|     400–499% |         1 |        1/62 |           1/20 |
|     500–749% |         2 |        1/52 |           1/20 |
|     750–899% |         2 |        1/47 |           1/20 |
|     900–999% |         2 |        1/40 |           1/20 |
| 1,000–1,249% |         4 |        1/37 |           1/20 |
| 1,250–1,499% |         4 |        1/35 |           1/10 |
| 1,500–1,999% |         4 |        1/31 |           1/10 |
|      2,000%+ |         8 |        1/28 |            1/5 |
