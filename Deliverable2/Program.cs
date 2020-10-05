using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            //User flips heads or tails

            Console.WriteLine("Do you want heads or tails?");
            string headsOrTailsGuess = Console.ReadLine();

            // User selecets amounts of flips
            Console.WriteLine("How many flips do you want?");
            double numberOfFlips = int.Parse(Console.ReadLine());

            // Coined if flipped B abount of times
            int correctCount = 0;
            Random rnd = new Random();
            for (int x = 0; x < numberOfFlips; x++)
            {
                int flip = rnd.Next(1, 3);
                if (flip == 2)
                {
                    Console.WriteLine("Heads");
                }
                if (flip == 1)
                {
                    Console.WriteLine("Tails");
                }
                if (headsOrTailsGuess.ToLower() == "heads" && flip == 2)
                {
                    correctCount++;
                }
                if (headsOrTailsGuess.ToLower() == "tails" && flip == 1)
                {
                    correctCount++;
                }
            }

            //Tell user how many they got correct and % of correct flips
            Console.WriteLine("You got " + correctCount + " correct!");
            double correctPercentage = correctCount / numberOfFlips * 100;
            Console.WriteLine("Your correct percentage was " + correctPercentage + "%");
        }
    }
}
