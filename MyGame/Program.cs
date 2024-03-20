using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Number of enemies not provided.");
                return;
            }

            int numEnemies = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[numEnemies];

            for (int i = 0; i < numEnemies; i++)
            {
                Console.Write("Name of the enemy " + (i + 1) + ": ");
                string name = Console.ReadLine();
                enemies[i] = new Enemy(name);
            }
        }
    }
}
