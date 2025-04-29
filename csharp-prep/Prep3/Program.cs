using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
     {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        while (guess != magicNumber)
        //int count_number = int count_number + 1;
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (magicNumber > guess)
            {
                Console.WriteLine("Guess higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Guess lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! Congrats!! it took ___ guesses!");
            }

        }                    
    }
}