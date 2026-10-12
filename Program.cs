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
                ======================================================================
                                             Menu options
                ======================================================================

                ↑/↓ To Navigate   ⏎/→ To Select   Esc To Exit

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
                            AddKillMenu();
                            break;

                        case 1:
                            //ViewDropChances();
                            break;

                        case 2:
                            //ViewKillHistory();
                            break;

                        case 3:
                            //ResetBLM();
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

    public static void AddKillMenu()
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
                "2000%+",
                "Undo Kill"
            ];

        List<EnrageBracket> bracket;


        var selectedOption = 0;
        while (true)
        {
            Console.Clear();
            Logo();

            Console.WriteLine(
                """"
                ======================================================================
                                              Add a kill
                ======================================================================
                **Story, Normal & Enrage (0-99%) don't count towards BLM**

                ↑/↓ To Navigate   ⏎/→ To Select   Esc/← To Return

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
                    //Add kill to List<EnrageBracket>
                    Console.WriteLine($"""

                        Kill added
                        
                        Press any button...
                        """);
                    Console.ReadKey();
                    break;
                    

                case ConsoleKey.Escape or ConsoleKey.LeftArrow:
                    return;
            }
        }
        
    }

    public static void Main()
    {
        Menu();
    }
}