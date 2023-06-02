using System;

namespace DesignerishMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Designerish Menu";

            string[] options = { "Option 1", "Option 2", "Option 3", "Option 4", "Option 5" };
            int selectedOption = 0;

            ConsoleKey key;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Designerish Menu ===\n");

                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedOption)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(">> " + options[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(options[i]);
                    }
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (selectedOption > 0)
                            selectedOption--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (selectedOption < options.Length - 1)
                            selectedOption++;
                        break;
                }
            } while (key != ConsoleKey.Enter);

            Console.Clear();
            Console.WriteLine("You selected: " + options[selectedOption]);
            Console.ReadLine();
        }
    }
}