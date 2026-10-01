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

public static class BlmCalculator
{
    public static int CalcDropRate(
        int accumulatedBLM,
        EnrageBracket enrageBracket)
        {
            return Math.Max(enrageBracket.BaseChance - accumulatedBLM,
                enrageBracket.MaximumChance);
        }
}


public static class Program
{
    public static void Main()
    {
        Console.Clear();

        var kills = new[]
        {
           EnrageData.Brackets[5],
           EnrageData.Brackets[6],
           EnrageData.Brackets[8],
           EnrageData.Brackets[9],
           EnrageData.Brackets[11],
       };

        var accumulatedBLM = 0;

        for (int kill = 0;
            kill < kills.Length;
            kill++)
        {
            var bracket = kills[kill];

            accumulatedBLM += bracket.Decrement;



            var currentDropRate =
                 BlmCalculator.CalcDropRate(accumulatedBLM, bracket);

            var killWithBLM = kill + 1;
            var enrage = bracket.Enrage;

            var decrementFromKill = bracket.Decrement;
            var baseDropChance = bracket.BaseChance;
            
            var bracketMaxBLM = bracket.MaximumChance;

            Console.WriteLine($"""
                |kill:   {killWithBLM}
                |Enrage: {enrage}%
                |
                |BLM From kill:   {decrementFromKill}
                |Accumulated BLM: {accumulatedBLM}
                |
                |Base Drop Chance:           1/{baseDropChance}
                |Current Drop chance:        1/{currentDropRate}
                |BLM Cap For Current Enrage: 1/{bracketMaxBLM}
                ---------------------------------------------
                """
            );
        }
    }
}