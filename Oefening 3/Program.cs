using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_3
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
            Console.Title = $"Exercise 3 {DateTime.Now.ToLongDateString()} or {DateTime.Now.ToShortDateString()} - " +
                            $"{DateTime.Now.ToLongTimeString()} or {DateTime.Now.ToShortTimeString()}";

            //Declare variables
            int quantity = 4, age;
            string input, firstname, lastname, ageGroup = "";
            DateTime dob;

            Console.WriteLine($"We ar going to determine the age group of {quantity} persons!\n");

            for (int i = 1; i <= quantity; i++)
            {
                do
                {
                    Console.Write($"Person {i}, enter your first name: ");
                    firstname = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(firstname));

                do
                {
                    Console.Write($"{firstname}, enter your last name: ");
                    lastname = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(lastname));

                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{firstname} {lastname}");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write($", enter your date of birth: ");
                    input = Console.ReadLine();

                } while (!DateTime.TryParse(input, out dob) || DateTime.Now < dob);

                age = DateTime.Now.Year - dob.Year;

                if (age >= 18)
                {
                    ageGroup = "Adult";
                }
                else if (age >= 10)
                {
                    ageGroup = "Teenager";
                }
                else if (age >= 3)
                {
                    ageGroup = "Todler";
                }
                else if (age >= 0)
                {
                    ageGroup = "Baby";
                }

                Console.Write($"\n{firstname} {lastname} - {age} years old belongs to age group: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{ageGroup}\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }

            Console.WriteLine("\nPress enter to continue...");

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
