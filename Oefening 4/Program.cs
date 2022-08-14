using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_4
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
            Console.Title = $"Exercise 4 {DateTime.Now.ToLongDateString()} or {DateTime.Now.ToShortDateString()} - " +
                            $"{DateTime.Now.ToLongTimeString()} or {DateTime.Now.ToShortTimeString()}";

            //Declare variables
            int counter = 0;
            string input;

            string title = "Pay attention and look very good at this sentence!";
            string sentence = "On the chair there is a sun hat and gingerbread.";

            //First screen
            Console.WriteLine($"\t{title}");
            Console.WriteLine($"\t{new string('-', title.Length)}");
            Console.WriteLine($"\t{sentence}");

            Console.WriteLine("\n\tPress enter to continue...");
            Console.ReadLine();

            //Reset console
            Console.Clear();

            //Second screen
            Console.WriteLine("Enter the sentence you were able to study on the previous screen!\n");

            do
            {
                counter++;
                Console.Write($"Attempt {counter}: ");
                input = Console.ReadLine();

            } while (input != sentence);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\nYou needed {counter} ");

            if (counter == 1)
            {
                Console.Write("attempt");
            }
            else
            {
                Console.Write("attempts");
            }

            Console.Write($" to reproduce: {sentence}\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
