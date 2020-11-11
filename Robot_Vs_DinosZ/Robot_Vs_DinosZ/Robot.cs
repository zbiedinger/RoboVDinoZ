using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_DinosZ
{
    class Robot
    {
        //Member Varibles
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;
      

        //Constructor
        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            
        }


        //MEMBER METHODS
        //Decrase health
        //Decrease changes depending on attack passed in. 
        public void DecreaseHealth(int attack)
        {
            health -= attack;
            if (health < 0)
            {
                health = 0;
            }
        }


        //Decrease Power Level 
        //Decrease by 10 for every attack. 
        public void DecreasePowereLevel()
        {
            powerLevel -= 10;
            if (powerLevel < 0)
            {
                powerLevel = 0;
            }
        }


        //Robot attacks
        //Current Robot attacks Dino passed in.
        //Displays who attacks who and their effected stats.
        public void RobotAttacks(Dinosaur dino)
        {
            dino.DecreaseHealth(weapon.attackPower);

            DecreasePowereLevel();

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{name} attacked {dino.type}");
            Console.WriteLine($"~~");
            Console.WriteLine($"{dino.type}'s health: {dino.health}");
            Console.WriteLine($"{name}'s power level: {powerLevel}\n");
        }
    }
}
