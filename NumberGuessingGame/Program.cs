using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();

            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int Guesses;

            while(playAgain) 
            {
                guess = 0;
                Guesses= 0;
                number = random.Next(min, max);

                while(guess !=number) 
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high");
                    }
                    else if(guess < number)
                    {
                        Console.WriteLine(guess + " is to low");
                    }
                    else
                    {
                        Console.WriteLine("You found the right number");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
