using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_6
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
            Console.Title = $"Exercise 6 {DateTime.Now.ToLongDateString()} or {DateTime.Now.ToShortDateString()} - " +
                            $"{DateTime.Now.ToLongTimeString()} or {DateTime.Now.ToShortTimeString()}";

            //Declare variables
            int minimum, maximum, guess, counter, lotteryball, quantity = 3;
            string input;

            Random random = new Random();

            do
            {
                Console.Write("Enter a minimum value: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out minimum));

            do
            {
                Console.Write($"Enter a maximum value higher than {minimum}: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out maximum) || maximum <= minimum);

            for (int i = 1; i <= quantity; i++)
            {
                lotteryball = random.Next(minimum, maximum + 1);

                Console.WriteLine($"\nLottery ball {i}\n");
                counter = 0;
                do
                {
                    counter++;
                    Console.Write($"Gues which number (between {minimum} and {maximum}) is on the ball? ");
                    input = Console.ReadLine();

                } while (!int.TryParse(input, out guess) || lotteryball != guess);

                Console.WriteLine($"You had to guess {counter} times!");
            }

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
