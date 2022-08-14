using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_1
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
            Console.Title = $"Exercise 1 {DateTime.Now.ToLongDateString()} or {DateTime.Now.ToShortDateString()} - " +
                            $"{DateTime.Now.ToLongTimeString()} or {DateTime.Now.ToShortTimeString()}";

            //Declare variables
            int number1, number2;
            string input, message;

            //Ask the user for the first number
            do
            {
                Console.Write("Give a first number: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out number1));


            //Ask the user for the second number
            do
            {
                Console.Write("Give a second number: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out number2));

            //Calculations

            //Two ways to use the if statement: long and short

            //Long

            //if (number1 > number2)
            //{
            //    message = $"{number1} - {number2} = {number1 - number2}";
            //}
            //else
            //{
            //    message = $"{number2} - {number1} = {number2 - number1}";
            //}

            //Short
            message = (number1 > number2) ? $"{number1} - {number2} = {number1 - number2}" : $"{number2} - {number1} = {number2 - number1}";

            //Results
            Console.WriteLine($"\n{message}");

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
