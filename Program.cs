using System.Text;

namespace RS3_ZamorakBLM;
public static class Program
{

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


        var selectedOption = 0;

        while (true)
        {
            Console.Clear();

            Logo();

            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            Console.WriteLine(
                """"
                =================================================
                                 Menu options
                =================================================

                Use arrow key ↑/↓ to navigate, use Enter ⏎ or Right Arrow → to select:

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
                    Console.Write("   ");
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


                case ConsoleKey.Enter or ConsoleKey.RightArrow:
                    switch (selectedOption)
                    {
                        case 0:
                            AddKill();
                            break;

                        case 1:
                            //View Current Dropchances
                            break;

                        case 2:
                            //View Kill History
                            break;

                        case 3:
                            //Reset BLM
                            break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\nShutting down\n");
                            Console.ResetColor();
                            Environment.Exit(0);
                            break;
                    }
                    break;
            }
        }
    }

    public static void AddKill()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.CursorVisible = false;

        string[] options =
            [
                "100-149%",
                "150-199%",
                "200-299%",
                "300-399%",
                "400-499%",
                "500-749%",
                "750-899%",
                "900-999%",
                "1000-1249%",
                "1250-1499%",
                "1500-1999%",
                "2000%+"
            ];


        var selectedOption = 0;
        while (true)
        {
            Console.Clear();

            Console.WriteLine(
                """"
                =================================================
                                 ADD A KILL
                =================================================

                ↑/↓ Navigate
                ⏎ To Select
                Esc To Return

                ###Story, Normal & Enrage (0-99%) don't count twoards BLM###

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
                    Console.Write("   ");
                    Console.WriteLine($" {options[i]}");
                }
            }

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    selectedOption--;
                    break;

                case ConsoleKey.DownArrow:
                    selectedOption++;
                    break;

                case ConsoleKey.Enter:

                    break;
            }
        }
        
    }

    public static void Main()
    {
        Menu();
    }


}



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