using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        // Stretch 2: keep playing as long as the user says "yes"
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            // Stretch 1: keep track of the number of guesses
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
    }
}