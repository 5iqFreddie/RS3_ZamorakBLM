namespace RS3_ZamorakBLM;
public record EnrageBracket(
    int Enrage,
    int Decrement,
    int BaseChance,
    int MaximumChance
);
public static class EnrageData{
    public static readonly EnrageBracket[] Brackets =
    [
        new(Enrage: 100,  Decrement: 1,  BaseChance: 80, MaximumChance: 20), // 0
        new(Enrage: 150,  Decrement: 1,  BaseChance: 77, MaximumChance: 20), // 1
        new(Enrage: 200,  Decrement: 1,  BaseChance: 72, MaximumChance: 20), // 2
        new(Enrage: 300,  Decrement: 1,  BaseChance: 67, MaximumChance: 20), // 3
        new(Enrage: 400,  Decrement: 1,  BaseChance: 62, MaximumChance: 20), // 4
        new(Enrage: 500,  Decrement: 2,  BaseChance: 52, MaximumChance: 20), // 5
        new(Enrage: 750,  Decrement: 2,  BaseChance: 47, MaximumChance: 20), // 6
        new(Enrage: 900,  Decrement: 2,  BaseChance: 40, MaximumChance: 20), // 7
        new(Enrage: 1000, Decrement: 4,  BaseChance: 37, MaximumChance: 20), // 8
        new(Enrage: 1250, Decrement: 4,  BaseChance: 35, MaximumChance: 10), // 9
        new(Enrage: 1500, Decrement: 4,  BaseChance: 31, MaximumChance: 10), // 10
        new(Enrage: 2000, Decrement: 8,  BaseChance: 28, MaximumChance: 5 ), // 11
    ];
}
