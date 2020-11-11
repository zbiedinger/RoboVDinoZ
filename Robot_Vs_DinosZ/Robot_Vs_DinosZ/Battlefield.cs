using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_DinosZ
{
    class Battlefield
    {
        //Memeber Varibles
        int battleLocation;
        public Fleet fleet;
        public Herd herd;
        bool defaultSettings;
        public int numberInBattle;
        Random rand;


        //Constructor
        public Battlefield()
        {
            battleLocation = 0;
            defaultSettings = true;
            numberInBattle = 3;
            rand = new Random();
        }

        //MEMBER METHODS
        //Default setup
        //Asks user if they want to set up the game or not. 
        //Then set the defaultSettings operator accordingly.
        public void ManualOrDefault()
        {
            ArtWork("start");
            Console.WriteLine("Manual: Choose worriors and change weapons after each attack.");
            Console.WriteLine("Default: Everything is picked at random and no user input.\n");
            Console.WriteLine("Manual or Default settings? m or d");
            string answer = Console.ReadLine();
            if (answer == "m")
            {
                defaultSettings = false;
            }
            else
            {
                battleLocation = rand.Next(4) + 1;
            }
        }


        //Display current stats
        //used to check the battle, health and power methods throughout the game.
        //NOT IN USE
        public void DisplayStats()
        {

                Console.WriteLine($"\n{fleet.fleetOfRobots[0].name}'s stats             {herd.herdOfDinos[0].type}'s stats");
                Console.WriteLine($"Health: {fleet.fleetOfRobots[0].health}                 Health: {herd.herdOfDinos[0].health}");
                Console.WriteLine($"Power Level: {fleet.fleetOfRobots[0].powerLevel}            Energy Level: {herd.herdOfDinos[0].energy}");

        }


        //Art Work
        //Displays text art during game based on string passed.
        //No user input.
        public void ArtWork(string artToDisplay)
        {
            switch(artToDisplay)
            {
                case "city":
                    Console.WriteLine("" +
                        "                              .|\n" +
                        "                             |  |\n" +
                        "                             | '|            ._____\n" +
                        "                    ___      |  |            |.   | ' .---'|\n" +
                        "               _.- '   ' -. |   |     .--'|  ||   | _|    |\n" +
                        "     .- '|  _.|  |         ||  ' - __ |   |  |    ||      |\n" +
                        "     | ' | |.    |         ||       | |   |  |    ||      |\n" +
                        " ___ |   '-'     '         ''       '-'   '-.'    '`      | ____\n" +
                        "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                     Console.WriteLine("\n                         CITY BATTLE!");

                    break;
                case "mountain":
                     Console.WriteLine("        _    .  ,   .           .\n" +
                        "    *  / \\_ *  / \\_       _  *          *    /\'__        *   \n" +
                        "      /    \\  /     \\,   ((         .     _ /  /  \\   *'.    \n" +
                        " .   /\\/\\  /\\/ :' __  \\_  `            _^/  ^/     `--.     \n" +
                        "    /    \\/  \\  _ /  \\-'\\      *      /.' ^_    \\_.   '\\ *\n" +
                        "  /\\  .-   `. \\/     \\  / ==~=-=~=-=-;.  _/ \\   -. `_ /   \\\n" +
                        " /  `-.__ ^   / .- '.--\\ ~=-=~_=-=~=^/  _  `--./  .-'   `-     \n" +
                        "/         `. / /        `.~-^=-=~=^=.-'        ' -._ `._        \n");
                    Console.WriteLine("\n                      MOUNTAIN BATTLE");
                    break;

                case "space":
                    Console.WriteLine(".         _  .          .          .    +     .          .          .      .   \n" +
                        "        .(_).            .            .            .                :          \n" +
                        "        .   .      .    .     .     .    .      .   .      . .  .  -+-        .\n" +
                        "          .           .   .        .           .          /         :  .       \n" +
                        "    . .        .  .      /.   .      .    .     .     .  / .      . ' .        \n" +
                        "        .  +       .    /     .          .          .   /      .               \n" +
                        "       .            .  /         .            .        *   .         .     .   \n" +
                        "      .   .      .    *     .     .    .      .   .       .  .                 \n" +
                        "          .           .           .           .           .         +  .       \n" +
                        "  . .        .  .       .   .      .    .     .     .    .      .   .          \n" +
                        "     .             .                     .            .                   .    \n" +
                        " .   +                 .___ /\\_._ / ~~\\_...__ /\\__.._._ / ~\\        .      \n" +
                        "       .         _.--'                                      `--./\\          . \n" +
                        "       / ~~\\/ ~\\                                                  `-/ ~\\_.  \n" +
                        " . .- '                                                                  `-/\\_\n");
                    Console.WriteLine("                                       SPACE BATTLE!");
                    break;

                case "farm":
                    Console.WriteLine("                              +&-\n" +
                        "                            _.-^-._      .--.\n" +
                        "                        .- '   _   ' -. | __ |\n" +
                        "                       /     | _ |     \\|    |\n" +
                        "                      /                 \\    |\n" +
                        "                     /|     _______     |\\   |\n" +
                        "                      |    | ==|== |    |    |\n" +
                        "  | ---| ---| ---| ---|    |-- | --|    |    |\n" +
                        "  | ---| ---| ---| ---|    | ==|== |    |    |\n" +
                        " ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
                    Console.WriteLine("\n                  FARM BATTLE!");
                    break;
                case "robot":
                    Console.WriteLine("<><><><><><><><><><><><><><><><>");
                    Console.WriteLine("<><><><><><><><><><><><><><><><>");
                    Console.WriteLine("        \\_/\n" +
                        "       (* *)\n" +
                        "      __)#(__\n" +
                        "    ( ) ... ( ) (_)\n" +
                        "    || | _ | || //\n" +
                        ">== () |   | () /\n" +
                        "      _(___)_\n" +
                        "     [-]   [-]\n");
                    Console.WriteLine("<><><><><><><><><><><><><><><><>");
                    Console.WriteLine("<><><><><><><><><><><><><><><><>");
                    break;
                case "dino":
                    Console.WriteLine("<><><><><><><><><><><><><><><><>");
                    Console.WriteLine("<><><><><><><><><><><><><><><><>");
                    Console.WriteLine("                 __\n" +
                        "                / _)\n" +
                        "      _.----._ / /\n" +
                        "     /         /\n" +
                        " __ /  (  | (  |\n" +
                        "/ __.- '|_|--|_|\n");
                    Console.WriteLine("<><><><><><><><><><><><><><><><>");
                    Console.WriteLine("<><><><><><><><><><><><><><><><>");
                    break;
                case "missed":
      Console.WriteLine("   _____  .___  _________ ____________________________    \n" +
                        "  /     \\ |   |/ _____//   _____/\\_   _____/\\______   \\   \n" +
                        " /  \\ /  \\|   |\\_____  \\ \\_____  \\  |    __)_  |    |  \\  \n" +
                        "/    Y    \\   |/        \\/        \\ |        \\ |    `   \\ \n" +
                        "\\____|__  /___/_______  /_______  //_______  //_______  / \n" +
                        "        \\/            \\/        \\/         \\/         \\/ \n");
                    break;
                case "battle":
                    Console.WriteLine("\n<><><><><><><><><><><><><><><><>");
                    Console.WriteLine("<><><><><><><><><><><><><><><><>");
                    Console.WriteLine("         BATTLE BEGINS");
                    Console.WriteLine("<><><><><><><><><><><><><><><><>");
                    Console.WriteLine("<><><><><><><><><><><><><><><><>\n");
                    break;
                case "start":
                    Console.WriteLine("\n\n///////////////////////////////////\n");
                    Console.WriteLine("         START OF NEW GAME");
                    Console.WriteLine("\n///////////////////////////////////\n");
                    break;
                case "--":
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("-------------------------------");
                    break;

            }
        }


        //Choose the Battlefield and assign the homefield health advantage.
        //This instantiates the fleet and herd of robots and dinos.
        //This is done automatically or manually.
        public void ChooseBattlefield()
        {
            if (!defaultSettings)
            {
                Console.WriteLine("Where is the  battle feild?");
                Console.WriteLine("1.City  2.Mountains  3.Space  4.Farm");
                battleLocation = int.Parse(Console.ReadLine());
            }
                
            switch (battleLocation)
            {
                case 1:
                    ArtWork("city");
                    fleet = new Fleet(5);
                    herd = new Herd(0);
                    break;

                case 2:
                    ArtWork("mountain");
                    fleet = new Fleet(0);
                    herd = new Herd(5);
                    break;

                case 3:
                    ArtWork("space");
                    fleet = new Fleet(10);
                    herd = new Herd(0);
                    break;

                case 4:
                    ArtWork("farm");
                    fleet = new Fleet(0);
                    herd = new Herd(10);
                    break;
            }
        }


        //User interface
        //Home base for all cool stuff going on
        //Logic for battle:
        // - Asks user about set up of game, if default then everything is set randomly.
        // - Controls who attacks and wins a round/war
        public void HaveBattle()
        {
            ManualOrDefault();
            ChooseBattlefield();
            
            //Chooing how many Robots/Dinosaurs will battle if set to manual
            if(!defaultSettings)
            {
                Console.WriteLine("\nHow many are going to battle?");
                numberInBattle = int.Parse(Console.ReadLine());
            }
            fleet.ChooseRobotFleet(numberInBattle, defaultSettings);
            herd.ChooseDinoHerd(numberInBattle, defaultSettings);


            ArtWork("battle");

            //Actual battle. Will continue until all of one team is dead.
            while (fleet.fleetOfRobots.Count != 0 && herd.herdOfDinos.Count != 0)
            {
                //Attacks controlled by power/energy level. If zero then no attack that round.
                if (fleet.fleetOfRobots[0].powerLevel == 0)
                {
                    Console.WriteLine($"{fleet.fleetOfRobots[0].name} has low power and can't attack this round!\n");
                    fleet.fleetOfRobots[0].powerLevel = 50;
                    herd.herdOfDinos[0].DinoAttack(fleet.fleetOfRobots[0], 10);
                    ArtWork("--");
                }
                else if (herd.herdOfDinos[0].energy == 0)
                {
                    Console.WriteLine($"{herd.herdOfDinos[0].type} has low energy and can't attack this round!\n");
                    
                    herd.herdOfDinos[0].energy = 50;
                    fleet.fleetOfRobots[0].RobotAttacks(herd.herdOfDinos[0]);
                    
                    ArtWork("--");
                }
                else
                {
                    //Attacks controlled by random number. If random number is less than 3, their attack misses.
                    if (rand.Next(10) > 2)
                    {
                        fleet.fleetOfRobots[0].RobotAttacks(herd.herdOfDinos[0]);
                    }
                    else
                    {
                        ArtWork("--");

                        Console.WriteLine($"\n{fleet.fleetOfRobots[0].name}'s attack\n");
                        ArtWork("missed");
                    }

                    if (rand.Next(10) > 2)
                    {
                        herd.herdOfDinos[0].DinoAttack(fleet.fleetOfRobots[0], 10);
                    }
                    else
                    {
                        Console.WriteLine($"\n{herd.herdOfDinos[0].type}'s attack\n");
                        ArtWork("missed");
                        ArtWork("--");
                    }
                }

                //Deaths are counted by removal from the fleet/herd list
                if (fleet.fleetOfRobots[0].health == 0)
                {
                    ArtWork("dino");
                    Console.WriteLine($"{herd.herdOfDinos[0].type} WON THIS ROUND\n");
                    fleet.fleetOfRobots.RemoveAt(0);
                }
                else if (herd.herdOfDinos[0].health == 0)
                {
                    ArtWork("robot");
                    Console.WriteLine($"{fleet.fleetOfRobots[0].name} WON THIS ROUND\n");
                    herd.herdOfDinos.RemoveAt(0);
                }
                //If on manual mode, then after each round the use is asked to change weapon and attack
                else if(!defaultSettings)
                {
                    Console.WriteLine("Weapon and Attack change? y or n");
                    string answer = Console.ReadLine();
                    if(answer == "y" || answer == "Y")
                    {
                        fleet.ChangeRobotWeapon(fleet.fleetOfRobots[0]);
                        herd.herdOfDinos[0].ChangeDinoAttack();
                    }
                }
            }

            //Winner of the game is the fleet/herd list that is not empty
            if(fleet.fleetOfRobots.Count != 0)
            {
                Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");
                Console.WriteLine("    ROBOTS WIN THE WAR!");
                Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");
            }
            else
            {
                Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");
                Console.WriteLine("   DINOSAURS WIN THE WAR!");
                Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");
            }
            
            Console.ReadLine();
        }

    }
}
