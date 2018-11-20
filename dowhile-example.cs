using System;

namespace WhileLoops
{
    class Program
    {
        static void Main()
        {
            bool isGuessed = false;
            Random rnd = new Random();
            int rightNumber = rnd.Next(1, 100);

            while(!isGuessed)
            {
                Console.WriteLine("Guess a number between 1 and 100:");
                string guess = Console.ReadLine();

                if(byte.TryParse(guess, out byte result))
                {
                    if(result == rightNumber)
                    {
                        isGuessed = true;
                        Console.WriteLine("Congrats, you guessed right!");
                    }
                    else if(result < rightNumber)
                    {
                        Console.WriteLine("Sorry, your guess is lower than the correct number. Try again.");
                    }
                    else if(result > rightNumber)
                    {
                        Console.WriteLine("Sorry, your guess is higher than the correct number. Try again.");
                    }
                } else
                {
                    Console.WriteLine("Sorry, invalid input. Try again.");
                }
            }

            isGuessed = false;
            rightNumber = rnd.Next(1, 100);
            Console.WriteLine("\nAgain with Do-While loop...");

            do
            {
                Console.WriteLine("Guess a number between 1 and 100:");
                string guess = Console.ReadLine();

                if (byte.TryParse(guess, out byte result))
                {
                    if (result == rightNumber)
                    {
                        isGuessed = true;                        
                    }
                    else if (result < rightNumber)
                    {
                        Console.WriteLine("Sorry, your guess is lower than the correct number. Try again.");
                    }
                    else if (result > rightNumber)
                    {
                        Console.WriteLine("Sorry, your guess is higher than the correct number. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, invalid input. Try again.");
                }
            }
            while (!isGuessed);

            Console.WriteLine("Congrats, you guessed right!");

            Console.ReadLine();
        }
    }
}