using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrussianSoldier
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Initializing attributes, setting up Random system and defining the enemy type.

            Random rnd = new Random();

            //Secondary Stats//
            var user = new Attributes();
            user.Agility = 5;
            user.Intelligence = 5;

            //Primary Stats//
            int health = 100;
            int bullets = 50;
            int stamina = 25;

            //Damage values//
            int attackdamageMin = user.Agility - 3;
            int attackdamageMax = user.Agility - 1;

            int bulletdamage = user.Intelligence + 1;

            //Defining enemy type and attributes//
            int enemyhealth = 50;
            string CurrentEnemy = "";

            string FrenchSoldier = "Frenchy";
            string RussianSoldier = "Russian";
            string BritishSoldier = "Brit";

            if(CurrentEnemy == "")
            {
                int randomnumber1 = rnd.Next(1, 8);
                Console.WriteLine(randomnumber1);

            

            }


            

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            while (enemyhealth > 0)
            {
                Action:
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Choose your action son of the mighty Prussia:");
                Console.WriteLine("Your stats: {0} Health {1} Bullets {2} Stamina", health, bullets,stamina);
                Console.WriteLine("(Charge, Shoot, Item, Flee)");
                Console.WriteLine("");

                string action = Console.ReadLine();
                Console.WriteLine("");

                if (action == "Charge")
                {
                    int randomnumber = rnd.Next(1, 100);
                    if (randomnumber <= 50)
                    {
                        enemyhealth = enemyhealth - attackdamageMin;
                        Console.WriteLine("You charge forth in the name of the Kaiser");
                        Console.WriteLine("Your foe is now reduced to: {0}HP", enemyhealth);
                    }
                    else if(randomnumber >= 51)
                    {
                        enemyhealth = enemyhealth - attackdamageMax;
                        Console.WriteLine(enemyhealth);
                        Console.WriteLine("You charge forth in the name of the Kaiser");
                        Console.WriteLine("Your foe is now reduced to: {0}HP", enemyhealth);
                    }
                }
                if (action == "Shoot")
                {
                    int randomnumber = rnd.Next(1, 5);
                    if (randomnumber > 1.5)
                    {
                        Console.WriteLine("You fired your musket and hit.");
                        enemyhealth = enemyhealth - bulletdamage;
                        Console.WriteLine(enemyhealth);
                    }
                    if (randomnumber < 1.5)
                    {
                        Console.WriteLine("You fired your musket and missed.");
                    }
                }
                if (action == "Item")
                {
                    Console.WriteLine("Which of the following items do you want to expend?");
                    Console.WriteLine("Bandages, Package, Whiskey");
                    string Choice = Console.ReadLine();

                    if (Choice == "Bandages")
                    {
                        health = health + 1;
                        Console.WriteLine("You cover your wounds and return to battle.(+1HP)");
                        Console.WriteLine("Your health: {0}", health);
                    }
                    else if(Choice == "Package")
                    {
                        health = health + 5;
                        Console.WriteLine("You use the emergency package.");
                        Console.WriteLine("Your health: {0}", health);
                    }
                    else if(Choice == "Whiskey")
                    {
                        health = health - 15;
                        Console.WriteLine("You drink the whiskey and charge back into battle with vigor.");
                        Console.WriteLine("Your health: {0}", health);
                    }
                    else
                    {
                        goto Action;
                    }
                }
                if(action == "Flee")
                {
                    Console.WriteLine("You fled the battlefield");
                    break;
                }
                Console.WriteLine("---------------------------------------------------------------------------------*-*PRUSSEN-GLORIA*-*------------------");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }

    }
}

