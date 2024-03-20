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
        }
    }
}
