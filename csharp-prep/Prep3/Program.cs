using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        while (true)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess = -5;
            int i = 0;
            // Console.WriteLine($"Number: {number}");

            while (guess != number)
            {
                i++;
                Console.Write("What is your guess? ");
                string guesss = Console.ReadLine();
                guess = Convert.ToInt32(guesss);

                if (guess > number)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher!");
                }
            }

            Console.WriteLine($"Congratulations! You guessed the number in {i} guess(es)!");
            Console.WriteLine($"The number was {number}");

            Console.Write("Play again? (y/n): ");
            string yorn = Console.ReadLine();
            string lowyorn = yorn.ToLower();
            if (lowyorn == "n")
            {
                break;
            }
        }
        Console.WriteLine("Thanks for playing!");
    }
}