using System;
namespace ConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "1":
                    case "sq":
                        Printer.PrintSquare();
                        break;
                    case "2":
                    case "rect":
                        Printer.PrintRectangle();
                        break;
                    case "3":
                    case "tri":
                        Printer.PrintTriangle();
                        break;
                    default:
                        Console.WriteLine("Invalid entry - Please try again!");
                        break;
                }
            } else {
                // Day 1 - instructions
                while (true) // Loop indefinitely..
                {
                    Printer.PrintInstructions();
                    string choice = Console.ReadLine();
                    if (choice.ToUpper() == "Q")
                    {
                        break;
                    }

                    switch (choice)
                    {
                        case "1":
                            Printer.PrintSquare();
                            break;
                        case "2":
                            Printer.PrintRectangle();
                            break;
                        case "3":
                            Printer.PrintTriangle();
                            break;
                        default:
                            Console.WriteLine("Invalid entry - Please try again!");
                            break;
                    }
                }
            }
        }

    }
}
