using System;

namespace MyGame
{
    public class Enemy
    {
        public string name;
        public float health;
        public float shield;

        public Enemy(string name)
        {
            this.name = SetName(name); // name is assigned to this.name
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public string SetName(string name)
        {
            if (name.Length > 8)
            {
                this.name = name.Substring(0, 8);
            }
            else
            {
                this.name = name;
            }
            return this.name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

            public void PickupPowerUp(PowerUp powerUp, float value)
            {
                switch (powerUp)
                {
                    case PowerUp.Health:
                        if (health + value > 100)
                        {
                            health = 100;
                        }
                        else
                        {
                            health += value;
                        }
                        break;
                    case PowerUp.Shield:
                        if (shield + value > 100)
                        {
                            shield = 100;
                        }
                        else
                        {
                            shield += value;
                        }
                        break;
                    default:
                        throw new ArgumentException("Invalid PowerUp type.");
                }
            }
    }
}
