using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrussianSoldier.Initialization__Start_Screen;

namespace ThePrussianSoldier
{
    class TheCombatSystem
    {
        PrimaryInformation Info;
        public TheCombatSystem(PrimaryInformation info)
        {
            Info = info;
        }
        
        public void Combat()
        {
            ////Initializing attributes, setting up Random system and defining the enemy type.
            
            Random rnd = new Random();
            Console.WriteLine("");
            
            //Damage values//
            int attackdamageMin = 2 + (Info.AGILITY / 4);
            int attackdamageMax = 2 + (Info.AGILITY / 2);

            int bulletdamage = 5 + (Info.INTELLIGENCE / 4);
            
            //Defining enemy type and attributes//
            int enemyhealth = 50;
            string CurrentEnemy = "";

            string FrenchSoldier = "Frenchy";
            string RussianSoldier = "Russian";
            string BritishSoldier = "Brit";

            if (CurrentEnemy == "")
            {
                //Determine the enemy type//
                int randomnumber1 = rnd.Next(1, 3);
                if (randomnumber1 == 1)
                {
                    Console.WriteLine("You encounter a British Soldier");
                    CurrentEnemy = "Brit";
                }
                if (randomnumber1 == 2)
                {
                    Console.WriteLine("You encounter a French Soldier");
                    CurrentEnemy = "Frenchy";
                }
                if (randomnumber1 == 3)
                {
                    Console.WriteLine("You encounter a Russian Soldier");
                    CurrentEnemy = "Russian";
                }
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            bool Condition = false;

            while (enemyhealth > 0 || Condition == true)
            {
                
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Choose your action son of the mighty Prussia:");
                Console.WriteLine("Your stats: Health {0} Bullets {1} Stamina {2}", Info.HP, Info.Bullets, Info.Stamina);
                Console.WriteLine("(Charge, Shoot, Special, Item, Flee)");
                Console.WriteLine("");

                string action = Console.ReadLine();
                Console.WriteLine("");
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                if (action == "Charge")
                {
                    int randomnumber = rnd.Next(1, 100);
                    if (randomnumber <= 50)
                    {
                        enemyhealth = enemyhealth - attackdamageMin;
                        Console.WriteLine("You charge forth in the name of the Prussian King.");
                        Console.WriteLine("Your foe is now reduced to: {0}HP", enemyhealth);
                    }
                    else if (randomnumber >= 51)
                    {
                        enemyhealth = enemyhealth - attackdamageMax;
                        Console.WriteLine("You charge forth in the name of the Prussian King.");
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
                        Info.Bullets = Info.Bullets - 1;
                        Console.WriteLine("Your foe is now reduced to: {0}HP", enemyhealth);
                    }
                    if (randomnumber < 1.5)
                    {
                        Console.WriteLine("You fired your musket and missed.");
                        Console.WriteLine("Your foe is now reduced to: {0}HP", enemyhealth);
                    }
                }
                if(action == "Special")
                {
                    if(Info.CMBT == 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("As a Scout of his Majesty Wilhelm, you pull yourself together to keep the fight alive.");
                        Console.WriteLine("You regenerate 15 HP");
                        Info.HP = Info.HP + 15;
                        Info.Stamina = Info.Stamina - 5;
                        Console.WriteLine("");
                    }
                    if (Info.CMBT == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("As part of the Cavalry of Prussia, you charge into battle horse and musket.");
                        int damageCavalry = enemyhealth - ((Info.AGILITY / 2) - (Info.INTELLIGENCE / 2));
                        Console.WriteLine("You deliver damage equal to {0} HP", damageCavalry);
                        enemyhealth = enemyhealth - ((Info.AGILITY / 2) - (Info.INTELLIGENCE / 2));
                        Info.Stamina = Info.Stamina - 5;
                        Console.WriteLine("");
                    }
                    if (Info.CMBT == 3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("As the Vanguard of the Prussian army, prepare yourself and then smash into the enemy.");
                        enemyhealth = enemyhealth - (Info.STRENGTH / 2);
                        int damageVanguard = enemyhealth - (Info.STRENGTH / 2);
                        Console.WriteLine("You deliver damage equal to {0} HP and also regenerate 5 HP yourself.", damageVanguard);
                        Info.HP = Info.HP + 5;
                        Info.Stamina = Info.Stamina - 5;
                        Console.WriteLine("");
                    }
                }
                if (action == "Item")
                {
                    Console.WriteLine("Which of the following items do you want to expend?");
                    Console.WriteLine("Bandages, Package, Whiskey");
                    string Choice = Console.ReadLine();

                    if (Choice == "Bandages" && Info.Bandages > 0)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP + 5;
                        Console.WriteLine("You cover your wounds and return to battle.(+1HP)");
                        Console.WriteLine("Your health: {0}", Info.HP);
                        Console.WriteLine("");
                    }
                    else if (Choice == "Package" && Info.Package > 0)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP + 10;
                        Console.WriteLine("You use the emergency package.");
                        Console.WriteLine("Your health: {0}", Info.HP);
                        Console.WriteLine("");
                    }
                    else if (Choice == "Whiskey" && Info.Whiskey > 0)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP + 30;
                        Console.WriteLine("You drink the whiskey and charge back into battle with vigor.");
                        Console.WriteLine("Your health: {0}", Info.HP);
                        Console.WriteLine("");
                    }
                    else
                    {
                        Condition = false;
                    }
                }
                if (action == "Flee")
                {
                    Console.WriteLine("You fled the battlefield");
                    break;
                }

                //ENEMY PHASE//
                //Takes the defined enemy type, random numbers decide the attack type.

                //BRIT
                if (CurrentEnemy == BritishSoldier)
                {
                    int randomnumberBRI = rnd.Next(1, 3);
                    
                    if (randomnumberBRI == 1)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP - 1;
                        Console.WriteLine("The Brit Engages");
                        Console.WriteLine("You are reduced to {0} HP", Info.HP);
                    }
                    if (randomnumberBRI == 2)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP - 2;
                        Console.WriteLine("The Brit Shoots his Rifle");
                        Console.WriteLine("You are reduced to {0} HP", Info.HP);
                    }
                    if (randomnumberBRI == 3)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP - 3;
                        Console.WriteLine("The Brit calls for help. Bullets fly towards you.");
                        Console.WriteLine("You are reduced to {0} HP", Info.HP);
                    }
                }

                //FRENCHY
                if (CurrentEnemy == FrenchSoldier)
                {
                    int randomnumberFRN = rnd.Next(1, 3);
                    
                    if (randomnumberFRN == 1)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP - 1;
                        Console.WriteLine("The Frenchy Engages");
                        Console.WriteLine("You are reduced to {0} HP", Info.HP);
                    }
                    if (randomnumberFRN == 2)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP - 2;
                        Console.WriteLine("The Frenchy Shoots his Rifle");
                        Console.WriteLine("You are reduced to {0} HP", Info.HP);
                    }
                    if (randomnumberFRN == 3)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP - 3;
                        Console.WriteLine("The Frenchy calls for help. Bullets fly towards you.");
                        Console.WriteLine("You are reduced to {0} HP", Info.HP);
                    }
                }

                //RUSSIAN
                if (CurrentEnemy == RussianSoldier)
                {
                    int randomnumberRUS = rnd.Next(1, 3);
                    

                    if (randomnumberRUS == 1)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP - 1;
                        Console.WriteLine("The Russian Engages");
                        Console.WriteLine("You are reduced to {0} HP", Info.HP);
                    }
                    if (randomnumberRUS == 2)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP - 2;
                        Console.WriteLine("The Russian Shoots his Rifle");
                        Console.WriteLine("You are reduced to {0} HP", Info.HP);
                    }
                    if (randomnumberRUS == 3)
                    {
                        Console.WriteLine("");
                        Info.HP = Info.HP - 3;
                        Console.WriteLine("The Russian calls for help. Bullets fly towards you.");
                        Console.WriteLine("You are reduced to {0} HP", Info.HP);
                    }
                }
                Info.Stamina = Info.Stamina + 1;
                Console.WriteLine("---------------------------------------------------------------------------------*-*PRUSSEN-GLORIA*-*------------------");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
