namespace RS3_ZamorakBLM;
public static class Program
{
    public static void Main(){
        Console.Clear();

        EnrageBracket[] kills = 
            [
           EnrageData.Brackets[5],
           EnrageData.Brackets[6],
           EnrageData.Brackets[8],
           EnrageData.Brackets[9],
           EnrageData.Brackets[11]
           ];

        var accumulatedBLM = 0;

        for (var kill = 0; kill < kills.Length; kill++)
        {
            var bracket = kills[kill];

            accumulatedBLM += bracket.Decrement;

            var isBLMActive =
                kill >= 10 && bracket.Enrage >= 100;

            if (isBLMActive)
            {
                accumulatedBLM += bracket.Decrement;
            }

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
                |_______________________________________________
                """
            );
        }
    }
}