using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_DinosZ
{
    class Dinosaur
    {
        //Member Varibles
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        public string[] attackTypes;
        public string currentAttack;

        //Constructor
        public Dinosaur(string type, int health, int attackPower, string currentAttack)
        {
            this.type = type;
            this.health = health;
            this.attackPower = attackPower;
            this.currentAttack = currentAttack;
            energy = 100;
            attackTypes = new string[5] {"bite", "scratch", "kick", "charge", "tail"};
        }
    

        //MEMBER METHODS
        //Decrase health
        //Decrease changes depending on attack passed in. 
        public void DecreaseHealth(int attack)
        {
            health -= attack;
            if(health < 0)
            {
                health = 0;
            }
        }


        //Decrease Energy Level 
        //Decrease by 10 for every attack. 
        public void DecreaseEnergy()
        {
            energy -= 10;
            if(energy < 0)
            {
                energy = 0;
            }
        }


        //Dinosaur attacks
        //Current Dinosaur uses attack passed in on Robot passed in.
        //Displays who attacks who and their effected stats.
        public void DinoAttack(Robot robo, int attack)
        {
            robo.DecreaseHealth(attack);

            DecreaseEnergy();

            Console.WriteLine($"{type} attacked {robo.name}");
            Console.WriteLine($"~~");
            Console.WriteLine($"{robo.name}'s health: {robo.health}");
            Console.WriteLine($"{type}'s power level: {energy}\n");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
        }

        //Change Attack
        //User asked to change current dino's attack.
        //Dino's attack changed and results are displayed.
        public void ChangeDinoAttack()
        {
            Console.WriteLine("What dino attack do you want?");
            Console.WriteLine("1.Bite  2.Scratch   3.Kick  4.charge  5.Tail Wack");
            int answer = int.Parse(Console.ReadLine());

            currentAttack = attackTypes[answer - 1];

            switch (answer)
            {
                case 1:
                    attackPower = 25;
                    break;
                case 2:
                    attackPower = 10;
                    break;
                case 3:
                    attackPower = 15;
                    break;
                case 4:
                    attackPower = 30;
                    break;
                case 5:
                    attackPower = 20;
                    break;


            }

            Console.WriteLine($"\n{type}'s next attack is {attackTypes[answer-1]}");
        }
    }
}
