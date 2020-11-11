using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Vs_DinosZ
{
    class Herd
    {
        //Memeber Varibles
        public List<Dinosaur> herdOfDinos;
        public int homeFeildAdvantage;
        Random rand;

        //Constructor
        public Herd(int homeFeildAdvantage)
        {
            this.homeFeildAdvantage = homeFeildAdvantage;
            herdOfDinos = new List<Dinosaur>();
            rand = new Random();
        }

        //MEMBER METHODS
        //Pick dino army
        //Passes in the numnber of dinos to add to the herd list
        //User inputs which dino and they are instaniated and added to list.
        public void ChooseDinoHerd(int numberOfDinos, bool defaultSettings)
        {
            int dinoPick;
            if (!defaultSettings)
            {
                Console.WriteLine("\nPick those Dinosaurs!");
                Console.WriteLine("1.T-Rex        2.Velociraptor  3.Ankylosaurus\n" +
                    "4.Triceratops  5.Pterodactyl   6.Apatosaurus\n" +
                    "7.Make your own");

                for (int i = 0; i < numberOfDinos; i++)
                {
                    if (i != 0)
                    {
                        Console.WriteLine("\nNext Dinosaur?");
                    }

                    dinoPick = int.Parse(Console.ReadLine());

                    switch (dinoPick)
                    {
                        case 1:
                            Dinosaur rex = new Dinosaur("T-Rex", 100 + homeFeildAdvantage, 50, "bite");
                            herdOfDinos.Add(rex);
                            Console.WriteLine($"\nDinosaur number {i + 1} is {herdOfDinos[i].type}");
                            break;
                        case 2:
                            Dinosaur velo = new Dinosaur("Velociraptor", 100 + homeFeildAdvantage, 30, "bite");
                            herdOfDinos.Add(velo);
                            Console.WriteLine($"\nDinosaur number {i + 1} is {herdOfDinos[i].type}");
                            break;
                        case 3:
                            Dinosaur anky = new Dinosaur("Ankylosaurus", 100 + homeFeildAdvantage, 40, "bite");
                            herdOfDinos.Add(anky);
                            Console.WriteLine($"\nDinosaur number {i + 1} is {herdOfDinos[i].type}");
                            break;
                        case 4:
                            Dinosaur tric = new Dinosaur("Triceratops", 100 + homeFeildAdvantage, 50, "bite");
                            herdOfDinos.Add(tric);
                            Console.WriteLine($"\nDinosaur number {i + 1} is {herdOfDinos[i].type}");
                            break;
                        case 5:
                            Dinosaur ptero = new Dinosaur("Pterodactyl", 100 + homeFeildAdvantage, 30, "bite");
                            herdOfDinos.Add(ptero);
                            Console.WriteLine($"\nDinosaur number {i + 1} is {herdOfDinos[i].type}");
                            break;
                        case 6:
                            Dinosaur apato = new Dinosaur("Apatosaurus", 100 + homeFeildAdvantage, 40, "bite");
                            herdOfDinos.Add(apato);
                            Console.WriteLine($"\nDinosaur number {i + 1} is {herdOfDinos[i].type}");
                            break;
                        case 7:
                            Console.WriteLine("\nWhat's this monster's... I mean Dino's type?");
                            string dinoName = Console.ReadLine();

                            Dinosaur mystory = new Dinosaur(dinoName, 100 + homeFeildAdvantage, 40, "bite");
                            herdOfDinos.Add(mystory);
                            Console.WriteLine($"\nDinosaur number {i + 1} is {herdOfDinos[i].type}");
                            break;
                    }
                }
                Console.WriteLine("\n{}{}{}{}{}{}{}{}{}{}{}{}");
            }
            else 
            {
                for (int i = 0; i < numberOfDinos; i++)
                {
                    dinoPick = rand.Next(5) + 1;

                    switch (dinoPick)
                    {
                        case 1:
                            Dinosaur rex = new Dinosaur("T-Rex", 100 + homeFeildAdvantage, 50, "bite");
                            herdOfDinos.Add(rex);
                            break;
                        case 2:
                            Dinosaur velo = new Dinosaur("Velociraptor", 100 + homeFeildAdvantage, 30, "bite");
                            herdOfDinos.Add(velo);
                            break;
                        case 3:
                            Dinosaur anky = new Dinosaur("Ankylosaurus", 100 + homeFeildAdvantage, 40, "bite");
                            herdOfDinos.Add(anky);
                            break;
                        case 4:
                            Dinosaur tric = new Dinosaur("Triceratops", 100 + homeFeildAdvantage, 50, "bite");
                            herdOfDinos.Add(tric);
                            break;
                        case 5:
                            Dinosaur ptero = new Dinosaur("Pterodactyl", 100 + homeFeildAdvantage, 30, "bite");
                            herdOfDinos.Add(ptero);
                            break;
                        case 6:
                            Dinosaur apato = new Dinosaur("Apatosaurus", 100 + homeFeildAdvantage, 40, "bite");
                            herdOfDinos.Add(apato);
                            break;
                    }
                }

                Console.WriteLine("\nYour dinosaurs are:\n");
                for (int i = 0; i < numberOfDinos; i++)
                {
                    Console.WriteLine($"{i+1}. {herdOfDinos[i].type}");
                }
                Console.WriteLine("\n{}{}{}{}{}{}{}{}{}{}{}{}");
            }
        }
    }
}
