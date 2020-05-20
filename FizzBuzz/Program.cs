using System;

namespace FizzBuzzCSharp
{
    /// <summary>
    /// Classic FizzBuzz interview question.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            string userInput;
            int limit;

            Console.Clear();

            Console.Write("Enter a number between 1 and 100: ");
            userInput = Console.ReadLine();

            // validate user input is integer
            while (!int.TryParse(userInput, out limit))
            {
                Console.Write("Please enter a valid number: ");
                userInput = Console.ReadLine();
            }

            // main FizzBuzz loop
            for (int counter = 1; counter <= limit; counter++)
            {
                if (counter % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (counter % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (counter % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}

