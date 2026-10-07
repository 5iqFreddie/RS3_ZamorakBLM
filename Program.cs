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

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(".______    __      .___  ___.      ______     ___       __        ______ \r\n|   _  \\  |  |     |   \\/   |     /      |   /   \\     |  |      /      |\r\n|  |_)  | |  |     |  \\  /  |    |  ,----'  /  ^  \\    |  |     |  ,----'\r\n|   _  <  |  |     |  |\\/|  |    |  |      /  /_\\  \\   |  |     |  |     \r\n|  |_)  | |  `----.|  |  |  |    |  `----./  _____  \\  |  `----.|  `----.\r\n|______/  |_______||__|  |__|     \\______/__/     \\__\\ |_______| \\______|\r\n");
        Console.ResetColor();
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