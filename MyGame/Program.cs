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

            for (int i = 0; i < numEnemies; i++)
            {
                Enemy currentEnemy = enemies[i];
                Console.WriteLine("Name: " + currentEnemy.GetName());
                Console.WriteLine("Health: " + currentEnemy.GetHealth());
                Console.WriteLine("Shield: " + currentEnemy.GetShield());
                Console.WriteLine();
            }

            Enemy enemy = enemies[0];
            Console.WriteLine("Initial health: " + enemy.GetHealth());
            Console.WriteLine("Initial shield: " + enemy.GetShield());

            enemy.PickupPowerUp(PowerUp.Health, 50);
            Console.WriteLine("Health after power-up: " + enemy.GetHealth());

            enemy.TakeDamage(25);
            Console.WriteLine("Health after damage: " + enemy.GetHealth());

            enemy.PickupPowerUp(PowerUp.Shield, 75);
            Console.WriteLine("Shield after power-up: " + enemy.GetShield());

            enemy.TakeDamage(40);
            Console.WriteLine("Shield after damage: " + enemy.GetShield());

            
        }
    }
}
