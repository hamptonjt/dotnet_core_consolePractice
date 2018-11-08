using System;

namespace ConsolePractice
{
    class Printer {
        public static void PrintInstructions()
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

        public static void PrintSquare(string c, int w)
        {
            /* Day 2 - prompts for extra parameters
            Console.Write("Please Enter the character you want to use for your Square: ");
            string c = Console.ReadLine();

            Console.Write("Please Enter the width/height of your Square: ");
            int w = Convert.ToInt16(Console.ReadLine());
            */

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write($"{c} ");
                }
                Console.Write("\n");
            }
        }

        public static void PrintRectangle(string c, int w, int h)
        {
            /* Day 2 - prompts for extra parameters
            Console.Write("Please Enter the character you want to use for your Rectangle: ");
            string c = Console.ReadLine();

            Console.Write("Please Enter the width of your Rectangle: ");
            int w = Convert.ToInt16(Console.ReadLine());

            Console.Write("Please Enter the height of your Rectangle: ");
            int h = Convert.ToInt16(Console.ReadLine());
            */

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write($"{c}");
                }
                Console.Write("\n");
            }
        }

        public static void PrintTriangle(string c, int w)
        {
            /* Day 2 - prompts for extra parameters
            Console.Write("Please Enter the character you want to use for your Triangle: ");
            string c = Console.ReadLine();

            Console.Write("Please Enter the width of your Triangle: ");
            int w = Convert.ToInt16(Console.ReadLine());
            */

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