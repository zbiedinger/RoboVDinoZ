using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_DinosZ
{
    class Fleet
    {
        //Memeber Varibles
        public List<Robot> fleetOfRobots;
        int homeFeildAdvantage;
        Random rand;


        //Constructor
        public Fleet(int homeFeildAdvantage)
        {
            this.homeFeildAdvantage = homeFeildAdvantage;
            fleetOfRobots = new List<Robot>();
            rand = new Random();
        }

        //MEMBER METHODS
        //Weapon change
        //User asked to change passed in robot's weapon.
        //Robot's weapon object changed and results are displayed.
        public void ChangeRobotWeapon(Robot bot)
        {
            Console.WriteLine("\nWhat weapon for your robot?");
            Console.WriteLine("1.Gun  2.Sword  3.Spoon  4.Lazor  5.Blaster  6.Corpse");
            int newWeapon = int.Parse(Console.ReadLine());

            switch (newWeapon)
            {
                case 1:
                    Weapon gun = new Weapon("Gun", 20, 10);
                    bot.weapon = gun;
                    break;
                case 2:
                    Weapon sword = new Weapon("Sword", 10, 40);
                    bot.weapon = sword;
                    break;
                case 3:
                    Weapon spoon = new Weapon("Spoon", 7, 5);
                    bot.weapon = spoon;
                    break;
                case 4:
                    Weapon lazor = new Weapon("Lazor", 25, 80);
                    bot.weapon = lazor;
                    break;
                case 5:
                    Weapon blaster = new Weapon("Blaster", 15, 30);
                    bot.weapon = blaster;
                    break;
                case 6:
                    Weapon corpse = new Weapon("Corpse", 10, 20);
                    bot.weapon = corpse;
                    break;
            }

            Console.WriteLine($"\n{bot.name}'s equipped with a {bot.weapon.name}.\n");
        }


        //Pick dino army
        //Passes in the numnber of robots to add to the fleet list
        //User inputs which robots to instaniat and added to the list.
        //If set to default the Robots are picked at random
        public void ChooseRobotFleet(int numberOfRobots, bool defaultSettings)
        {
            int robotPick;
            if (!defaultSettings)
            {
                Console.WriteLine("\n{}{}{}{}{}{}{}{}{}{}{}{}");
                Console.WriteLine("\nPick those Robots!");
                Console.WriteLine("1.Mega Man    2.Wall-E  3.Johnny 5\n" +
                    "4.Data  5.Astro boy   6.Iron Giant\n" +
                    "7.Make your own");

                for (int i = 0; i < numberOfRobots; i++)
                {
                    if (i != 0)
                    {
                        Console.WriteLine("\nNext Robot?");
                    }

                    robotPick = int.Parse(Console.ReadLine());

                    switch (robotPick)
                    {
                        case 1:
                            Robot megaMan = new Robot("Mega Man", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(megaMan);
                            Console.WriteLine($"\nRobot number {i + 1} is {fleetOfRobots[i].name}");
                            break;
                        case 2:
                            Robot wallE = new Robot("Wall-E", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(wallE);
                            Console.WriteLine($"\nRobot number {i + 1} is {fleetOfRobots[i].name}");
                            break;
                        case 3:
                            Robot johnny5 = new Robot("Johnny 5", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(johnny5);
                            Console.WriteLine($"\nRobot number {i + 1} is {fleetOfRobots[i].name}");
                            break;
                        case 4:
                            Robot data = new Robot("Data", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(data);
                            Console.WriteLine($"\nRobot number {i + 1} is {fleetOfRobots[i].name}");
                            break;
                        case 5:
                            Robot astroBoy = new Robot("Astro boy", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(astroBoy);
                            Console.WriteLine($"\nRobot number {i + 1} is {fleetOfRobots[i].name}");
                            break;
                        case 6:
                            Robot ironGiant = new Robot("Iron Giant", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(ironGiant);
                            Console.WriteLine($"\nRobot number {i + 1} is {fleetOfRobots[i].name}");
                            break;
                        case 7:
                            Console.WriteLine("\nWhat's the Robot's name?");
                            string robotName = Console.ReadLine();

                            Robot mystory = new Robot(robotName, 100 + homeFeildAdvantage, 40, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(mystory);
                            Console.WriteLine($"\nRobot number {i + 1} is {fleetOfRobots[i].name}");
                            break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numberOfRobots; i++)
                {
                    robotPick = rand.Next(5) + 1;

                    switch (robotPick)
                    {
                        case 1:
                            Robot megaMan = new Robot("Mega Man", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(megaMan);
                            break;
                        case 2:
                            Robot wallE = new Robot("Wall-E", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(wallE);
                            break;
                        case 3:
                            Robot johnny5 = new Robot("Johnny 5", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(johnny5);
                            break;
                        case 4:
                            Robot data = new Robot("Data", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(data);
                            break;
                        case 5:
                            Robot astroBoy = new Robot("Astro boy", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(astroBoy);
                            break;
                        case 6:
                            Robot ironGiant = new Robot("Iron Giant", 100 + homeFeildAdvantage, 100, new Weapon("Lazor", 30, 25));
                            fleetOfRobots.Add(ironGiant);
                            break;
                    }
                }

                Console.WriteLine("\n{}{}{}{}{}{}{}{}{}{}{}{}");
                Console.WriteLine("\nYour robots are:\n");
                for (int i = 0; i < numberOfRobots; i++)
                {
                    Console.WriteLine($"{i + 1}. {fleetOfRobots[i].name}");
                }
            }
        }
    }
}
