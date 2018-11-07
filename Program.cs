using System;

namespace ConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop indefinitely..
            {
                PrintInstructions();
                string choice = Console.ReadLine();
                if (choice.ToUpper() == "Q")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        PrintSquare();
                        break;
                    case "2":
                        PrintRectangle();
                        break;
                    case "3":
                        PrintTriangle();
                        break;
                    default:
                        Console.WriteLine("Invalid entry - Please try again!");
                        break;
                }
            }
        }

        static void PrintInstructions()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("We're going to build shapes with a given character!");
            Console.WriteLine();
            Console.WriteLine("Please choose a shape from the options below...");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("q/Q. Quit");
            Console.WriteLine();
            Console.Write("Enter your choice (1, 2, or 3 - or q/Q to quit): ");
        }

        static void PrintSquare()
        {
            Console.Write("Please Enter the character you want to use for your Square: ");
            string c = Console.ReadLine();

            Console.Write("Please Enter the width/height of your Square: ");
            int w = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write($"{c} ");
                }
                Console.Write("\n");
            }
        }

        static void PrintRectangle()
        {
            Console.Write("Please Enter the character you want to use for your Rectangle: ");
            string c = Console.ReadLine();

            Console.Write("Please Enter the width of your Rectangle: ");
            int w = Convert.ToInt16(Console.ReadLine());

            Console.Write("Please Enter the height of your Rectangle: ");
            int h = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write($"{c}");
                }
                Console.Write("\n");
            }
        }

        static void PrintTriangle()
        {
            Console.Write("Please Enter the character you want to use for your Triangle: ");
            string c = Console.ReadLine();

            Console.Write("Please Enter the width of your Triangle: ");
            int w = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= w; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{c}");
                }
                Console.Write("\n");
            }
        }
    }
}
