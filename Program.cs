//Author: Vanessa Machado
//This program will simulate two dice being rolled and keep track of the total
//It will print out the totals and a histogram of asterisks

using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] rollTotals = new int[13];

            //Get number of times to roll dice
            Console.Write("Hello! Please enter the number of times to roll the dice: ");
            int num_rolls = int.Parse(Console.ReadLine());


            //Simulate rolling of the dice
            for (int i = 0; i < num_rolls; i++)
            {
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);

                //Add rolls together and add to array
                int rolltot = roll1 + roll2;
                rollTotals[rolltot]++;
            }


            //Print out results from array and make histogram

            Console.WriteLine("\nResults:");
            for (int i = 2; i < 13; i++)
            {
                double percentage = (double)rollTotals[i] / num_rolls * 100;
                Console.WriteLine($"{ i}: { rollTotals[i]}" + " times rolled with a percentage of " + $"{ Math.Round(percentage, 2)}%");
            }

            Console.WriteLine("\nHistogram:");
            for (int i = 2; i < 13; i++)
            {
                double percentage = (double)rollTotals[i] / num_rolls * 100;
                Console.WriteLine($"{ i}: " + new string('*', (int)percentage));

            }

            Console.WriteLine("Thank you for playing!");  
        }
    }
}
