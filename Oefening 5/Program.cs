using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Reset console
            Console.Clear();

            //Edit window title
            Console.Title = $"Exercise 5 {DateTime.Now.ToLongDateString()} or {DateTime.Now.ToShortDateString()} - " +
                            $"{DateTime.Now.ToLongTimeString()} or {DateTime.Now.ToShortTimeString()}";

            //Declare variables
            int arrowLanded, score = 0, quantity = 3;
            string input, summary = "\n\t1. Arrow lands outside the board (0 points)" +
                                    "\n\t2. Arrow lands outer ring (20 points)" +
                                    "\n\t3. Arrow lands inner ring (50 points)" +
                                    "\n\t4. Arrow lands inside the bull's eye (100 points)";

            for (int i = 1; i <= quantity; i++)
            {
                do
                {
                    Console.WriteLine($"\tArrow {i}");
                    Console.WriteLine(summary);
                    Console.Write("\n\tWhere did you your arrow land? ");
                    input = Console.ReadLine();
                    Console.WriteLine();

                } while (!int.TryParse(input, out arrowLanded) || arrowLanded <= 0 || arrowLanded > 4);

                switch (input)
                {
                    case "1":
                        score += 0;
                        break;
                    case "2":
                        score += 20;
                        break;
                    case "3":
                        score += 50;
                        break;
                    case "4":
                        score += 100;
                        break;
                }
            }

            //Results
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\tYou scored {score} points!");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\tPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
