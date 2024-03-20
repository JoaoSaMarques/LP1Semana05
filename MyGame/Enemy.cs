using System;

namespace MyGame
{
    public class Enemy
    {
        public string name;
        public int health;
        public int shield;

        public Enemy(string name)
        {
            this.name = name; // name is assigned to this.name
            health = 100;
            shield = 0;
        }

    }
}
