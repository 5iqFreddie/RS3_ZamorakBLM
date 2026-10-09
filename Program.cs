using System.Text;

namespace RS3_ZamorakBLM;
public static class Program
{


    public static void Menu()
    {
        string[] options = 
        [
            "Calculate BLM",
            "View Current Drop Chances",
            "View Kill History",
            "Reset BLM",
            "Exit App"
        ];

        //Console.CursorVisible = false;
        //(var left, var top) = Console.GetCursorPosition();


        var selectedOption = 0;

        while (true)
        {
            Console.Clear();
            Logo();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(
                """"
                =================================================
                                 Menu options
                =================================================

                Use arrow key ↑/↓ to navigate, Enter ⏎ to select:

                """");

            for (var i = 0; i < options.Length; i++)
            {
                if (i == selectedOption)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" > ");
                    Console.WriteLine(options[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("  ");
                    Console.WriteLine($" {options[i]}");
                }
            }

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    selectedOption--;
                    if (selectedOption < 0)
                        selectedOption = options.Length - 1;
                    break;

                case ConsoleKey.DownArrow:
                    selectedOption++;
                    if (selectedOption >= options.Length)
                        selectedOption = 0;
                    break;
            }
        }
    }

    public static void Main(){
        Menu();

        //EnrageBracket[] kills = 
        //    [
        //   EnrageData.Brackets[5],
        //   EnrageData.Brackets[6],
        //   EnrageData.Brackets[8],
        //   EnrageData.Brackets[9],
        //   EnrageData.Brackets[11]
        //   ];

        //var accumulatedBLM = 0;

        //for (var kill = 0; kill < kills.Length; kill++)
        //{
        //    var bracket = kills[kill];

        //    accumulatedBLM += bracket.Decrement;

        //    var isBLMActive =
        //        kill >= 10 && bracket.Enrage >= 100;

        //    if (isBLMActive)
        //        accumulatedBLM += bracket.Decrement;
            

        //    var currentDropRate = BlmCalculator.CalcDropRate(accumulatedBLM, bracket);
        //    var killWithBLM = kill + 1;
        //    var enrage = bracket.Enrage;
        //    var decrementFromKill = bracket.Decrement;
        //    var baseDropChance = bracket.BaseChance;
        //    var bracketMaxBLM = bracket.MaximumChance;

        //    Console.WriteLine($"""
                
        //        |kill:   {killWithBLM}
        //        |Enrage: {enrage}%
        //        |
        //        |BLM From kill:   {decrementFromKill}
        //        |Accumulated BLM: {accumulatedBLM}
        //        |
        //        |Base Drop Chance:           1/{baseDropChance}
        //        |Current Drop chance:        1/{currentDropRate}
        //        |BLM Cap For Current Enrage: 1/{bracketMaxBLM}
        //        |_______________________________________________
        //        """
        //    );
        //}
    }

    //switch (choice)
    //{
    //    case "1":
    //        //CalculateBLM();
    //        break;

    //    case "2":
    //        //View Current Drop Chances
    //        break;

    //    case "3":
    //        //View kill History
    //        break;

    //    case "4":
    //        //Reset BlM
    //        break;

    //    case "0":
    //        Environment.ExitCode = 0;
    //        Environment.Exit(0);
    //        break;

    //    default:
    //        Console.WriteLine("\nInvalid Option.");
    //        Console.ReadKey();
    //        break;
    //}

    public static void Logo()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"""
            .______   __      .___  ___.     ______     ___     .__.       ______.
            |   _  \ |  |     |   \/   |    /      |   /   \    |  |      /      |
            |  |_)  ||  |     |  \  /  |   |  ,----'  /  ^  \   |  |     |  ,----'
            |   _  < |  |     |  |\/|  |   |  |      /  /_\  \  |  |     |  |     
            |  |_)  ||  `----.|  |  |  |   |  `----./  _____  \ |  `----.|  `----.
            |______/ |_______||__|  |__|    \______/__/     \__\|_______| \______|
            ######################################################################

            """
            );
        Console.ResetColor();
    }
}