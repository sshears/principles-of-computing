using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace high_low
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to the high low game.");

            // Starts counter
            int attempts;
            attempts = 0;

            // Generate a random number
            Random rng = new Random();
            int number = rng.Next(1, 10);

            // Loops game
            while (true)
            {
                // Counts attempt number
                attempts = attempts + 1;
                // User enters guess
                int guess = InputInt("Enter guess: ");

                // Compare guess to number
                if (guess < number)
                {
                    Console.WriteLine("Too low.");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too high.");
                }
                else
                {
                    Console.WriteLine("Correct.");
                    Console.WriteLine("It took you " + attempts + " attempts.");
                    break;
                }
            }

            // Wait for key press
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        // New function to input guess
        static int InputInt(string prompt)
        {
            // Assigns a value to guess
            int guess = 0;
            // Loops until a condition is met
            while (true)
            {
                // Tries for input attempt
                try
                {
                    Console.Write(prompt);
                    guess = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                // Executes a different code if an error is caught
                catch (Exception e)
                {
                    Console.WriteLine("Incorrect input. Please enter a whole number.");
                }
            }
            // Returns the guess value
            return guess;
        }
    }
}
