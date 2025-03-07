using System;

class Program
{
    static void Main(string[] args)

    {
        bool playAgain = true;

        while (playAgain)
        {

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            int guess;
            int guessCount = 0;
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (number == guess)
                {
                    Console.WriteLine($"You guessed it! Number of guessess: {guessCount}");
                }
                else if (number > guess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            } while (number != guess);
            Console.Write("Do you want to play again? (y/n): ");
            string response = Console.ReadLine().ToLower();
            if (response != "y")
            {
                playAgain = false;
            }

        }
    }
}