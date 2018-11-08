using System;
using McMaster.Extensions.CommandLineUtils; // Discovered this while googling how to add a 'help' section
namespace ConsolePractice
{
    class Program
    {
        public static int Main(string[] args)
        {
            var app = new CommandLineApplication();

            app.HelpOption();
            var optionShape = app.Option("-s|--shape <SHAPE>", "The Shape - \"square\", \"rect\", \"triangle\" without quotes ", CommandOptionType.SingleValue);
            var optionChar = app.Option("-c|--char <C>", "Character used to build shape", CommandOptionType.SingleValue);
            var optionWidth = app.Option<int>("-w|--width <N>", "Width of the shape", CommandOptionType.SingleValue);
            var optionHeight = app.Option<int>("-t|--height <N>", "Height of the shape", CommandOptionType.SingleValue);

            app.OnExecute(() =>
            {
                var shape = optionShape.HasValue() ? optionShape.Value() : "square";
                var c = optionChar.HasValue() ? optionChar.Value() : "X";
                var width = optionWidth.HasValue() ? optionWidth.ParsedValue : 5;
                var height = optionHeight.HasValue() ? optionHeight.ParsedValue : 5;

                switch (shape) {
                    case "square":
                        Printer.PrintSquare(c, width);
                        break;
                    case "rect":
                        Printer.PrintRectangle(c, width, height);
                        break;
                    case "triangle":
                        Printer.PrintTriangle(c, width);
                        break;
                    default:
                        Console.WriteLine("Invalid entry - Please try again!");
                        break;
                }
            });

            return app.Execute(args);

            // Day 2 using command line
            /*
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
            */
        }

    }
}
