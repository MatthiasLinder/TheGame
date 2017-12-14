using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrussianSoldier.Initialization__Start_Screen;
using ThePrussianSoldier.TheChapters;

namespace ThePrussianSoldier
{
    class TheChoiceScreen
    {
        PrimaryInformation Info;
     
        public TheChoiceScreen(PrimaryInformation info)
        {
            Info = info;
            initializeValues();
        }

        public void initializeValues()
        {
            Info.HP = 100;
            Info.Bullets = 50;
            Info.Gold = 500;
            Info.Stamina = 5;
            Info.STRENGTH = 1;
            Info.INTELLIGENCE = 1;
            Info.AGILITY = 1;
        }
        ////////////////////////
        //Initiate Choice Screen
        ////////////////////////
        public void Choices()
        {
            int ChapterDeterminant = 0;

            while (ChapterDeterminant == 0)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("[HP:{0} AMMO: GOLD:{1} ]", Info.HP, Info.Gold);
                Console.WriteLine("You are marching along a lonely road, what do you do?");
                Console.WriteLine("[Town, Patrol, Guard, Rest, Train, Stats]");

                string Answer = Console.ReadLine();

                if (Answer == "Town")
                {
                    Console.WriteLine("What do you wish to purchase whilst in the Town?");
                    Console.WriteLine("[Consumables, Library]");
                    string TownAnswer = Console.ReadLine();
                   
                    if (TownAnswer == "Consumables" && Info.Gold > 0)
                    {
                        Console.WriteLine("Which items do you want to purchase?");
                        Console.WriteLine("[Bullets, Bandages, Package, Whiskey]");
                        string ItemAnswer = Console.ReadLine();
                        if(ItemAnswer == "Bandages" && Info.Gold > 0)
                        {
                            Console.WriteLine("You buy some bandages from the infirmary.");
                            Console.WriteLine("New Item: Bandages");
                            Info.Gold = Info.Gold - 100;
                            Console.WriteLine(Info.Gold);
                            Info.Bandages = Info.Bandages + 1;
                        }
                        if (ItemAnswer == "Package" && Info.Gold > 0)
                        {
                            Console.WriteLine("You pay for a emergency medical package.");
                            Console.WriteLine("New Item: Package.");
                            Info.Gold = Info.Gold - 100;
                            Console.WriteLine(Info.Gold);
                        }
                        if (ItemAnswer == "Whiskey" && Info.Gold > 0)
                        {
                            Console.WriteLine("You buy some whiskey from the Tavern.");
                            Console.WriteLine("New Item: Whiskey.");
                            Info.Gold = Info.Gold - 100;
                            Console.WriteLine(Info.Gold);
                        }
                        if (ItemAnswer == "Bullets" && Info.Gold > 0 && Info.Bullets < 50)
                        {
                            Console.WriteLine("You buy some bullets,");
                            Info.Gold = Info.Gold - 50;
                            Console.WriteLine(Info.Gold);
                            Info.Bullets = Info.Bullets + 5;
                            Console.WriteLine(Info.Bullets);
                            
                        }
                    }
                    if (TownAnswer == "Library" && Info.Gold > 0)
                    {
                        Console.WriteLine("You go to the library to learn, you pay the entrance fee.");
                        Console.WriteLine("+1 Intelligence ; -100 Gold.");
                        Info.Gold = Info.Gold - 100;
                        Info.INTELLIGENCE = Info.INTELLIGENCE + 1;
                        Console.WriteLine(Info.INTELLIGENCE);
                        Info.UpdateINTELLIGENCE(Info.INTELLIGENCE);
                    }
                }
                if (Answer == "Patrol")
                {
                    Console.WriteLine("You encounter an enemy when patrolling the countryside.");
                    break;   
                }
                if (Answer == "Guard")
                {
                    Console.WriteLine("You guard the Town hall for gold.");
                    Console.WriteLine("+ 100 Gold.");
                    Info.Gold = Info.Gold + 100;
                    Console.WriteLine(Info.Gold);
                }
                if (Answer == "Rest" && Info.HP < 100)
                {
                    Console.WriteLine("You retire to the Barracks to rest.");
                    Console.WriteLine("+1 HealthPoint.");
                    Info.HP = Info.HP + 1;
                    Console.WriteLine(Info.HP);
                    Info.UpdateHP(Info.HP);
                }
                if (Answer == "Train")
                {
                    Console.WriteLine("You take part in some strength exercises.");
                    Console.WriteLine("+1 Strength");
                    Info.STRENGTH = Info.STRENGTH + 1;
                    Console.WriteLine(Info.STRENGTH);
                    Info.UpdateSTRENGTH(Info.STRENGTH);
                }
                if (Answer == "Drill")
                {
                    Console.WriteLine("You take part in Millitary drills.");
                    Console.WriteLine("+1 Agility.");
                    Info.AGILITY = Info.AGILITY + 1;
                    Console.WriteLine(Info.AGILITY);
                    Info.UpdateAGILITY(Info.AGILITY);
                }
                if (Answer == "Stats")
                {
                    Console.WriteLine("Str: {0} Int:{1} Agi: {2}", Info.STRENGTH, Info.INTELLIGENCE, Info.AGILITY);
                }

                if (Answer == "Break")
                {
                    break;
                }

                if (Answer == "Next Chapter")
                {
                    Console.WriteLine("Which Chapter?");
                    string v = Console.ReadLine();
                    if(Info.CPD == 0 && v == "First")
                    {
                        var F = new Chapter_2();
                        Info.CPD = 1;
                    }
                    if (Info.CPD == 1 && v == "Second")
                    {
                        var S = new Chapter_3();
                        Info.CPD = 2;
                    }
                    if (Info.CPD == 2 && v == "Third")
                    {
                        var T = new Chapter_4();
                        Info.CPD = 3;
                    }
                    if (Info.CPD == 3 && v == "Fourth")
                    {
                        var FO = new Chapter_5();
                    }
                }
            }
        }
    }
}
