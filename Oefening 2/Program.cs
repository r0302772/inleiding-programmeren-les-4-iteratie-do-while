using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            //Reset console
            Console.Clear();

            //Edit window title
            Console.Title = $"Exercise 2 {DateTime.Now.ToLongDateString()} or {DateTime.Now.ToShortDateString()} - " +
                            $"{DateTime.Now.ToLongTimeString()} or {DateTime.Now.ToShortTimeString()}";

            //Declare variables
            double priceExcluded, priceIncluded, tax;
            int quantity = 5;
            string input;

            for (int i = 1; i <= quantity; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\nArticle {i}\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                //Ask the user for a price tax excluded
                do
                {
                    Console.Write("Price (tax excluded): ");
                    input = Console.ReadLine();

                } while (!double.TryParse(input, out priceExcluded) || priceExcluded <= 0);

                //Ask the user for the tax
                do
                {
                    Console.Write("Tax-%: ");
                    input = Console.ReadLine();

                } while (!double.TryParse(input, out tax) || tax < 0);

                priceIncluded = priceExcluded + (priceExcluded * tax / 100);

                Console.WriteLine($"\nPrice (tax included): {priceIncluded}");
            }

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
