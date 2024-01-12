using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is the magic number? ");
        string magicGuess = Console.ReadLine();
        int Number = int.Parse(magicGuess);


        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber = 0;

        while (Number != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guesses = Console.ReadLine();
            int x = int.Parse(guesses);
            guessNumber++;

            if (x > Number) 
            {
                Console.WriteLine("higher");
            } 
            
            else if (x < Number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("congratulations you guessed it!");
                Console.WriteLine($"You have played {guessNumber} guesses");
                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgain = Console.ReadLine();

                if (playAgain == "yes")
                {
                    magicNumber = randomGenerator.Next(1, 101);
                    guessNumber = 0;
                }
                else
                {
                    Console.WriteLine("Thank you for playing");
                    break;
                }
            }            
        }

    }

}