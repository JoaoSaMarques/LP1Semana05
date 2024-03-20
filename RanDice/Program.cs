using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int s;
            if (args.Length < 2 || !int.TryParse(args[0], out n) || !int.TryParse(args[1], out s))
            {
                Console.WriteLine("Please input 2 numbers");
                return;
            }

            // Seed random number generator
            System.Random random = new System.Random(s);

            // Roll dice and calculate sum
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int roll = random.Next(1, 7); // Roll a die between 1 and 6
                sum += roll;
            }

            // Print result
            Console.WriteLine($"Rolled {n} dice with seed {s} and got a sum of {sum}");
        }
    }
}