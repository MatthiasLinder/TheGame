using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrussianSoldier.Initialization__Start_Screen;

namespace ThePrussianSoldier
{
    class TheChoiceScreen
    {
        PrimaryInformation Info;
        //ITEMS//
        int Bandages = 1;
        public int GetBandages()
        {
            return Bandages;
        }
        //STATS
        int Gold = 500;
        public int GetGold()
        {
            return Gold;
        }
        int HP = 100;
        public int GetHP()
        {
            return HP;
        }
        int STRENGTH = 1;
        public int GetSTRENGTH()
        {
            return STRENGTH;
        }
        int INTELLIGENCE = 1;
        public int GetINTELLIGENCE()
        {
            return STRENGTH;
        }
        int AGILITY = 1;
        public int GetAGILITY()
        {
            return STRENGTH;
        }

        public TheChoiceScreen(PrimaryInformation info)
        {
            Info = info;
        }

        //Initiate Choice Screen
        public void Choices()
        {
            int ChapterDeterminant = 0;

            while (ChapterDeterminant == 0)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("[HP:{0} AMMO: GOLD:{1} ]", HP, Gold);
                Console.WriteLine("You are marching along a lonely road, what do you do?");
                Console.WriteLine("[Town, Patrol, Guard, Rest, Train, Stats]");

                string Answer = Console.ReadLine();

                if (Answer == "Town")
                {
                    Console.WriteLine("What do you wish to purchase whilst in the Town?");
                    Console.WriteLine("[Weapons, Armor, Consumables, Library/Laboratory]");
                    string TownAnswer = Console.ReadLine();
                    if (TownAnswer == "Weapons" && Gold >0)
                    {
                        Gold = Gold - 100;
                        Console.WriteLine(Gold);                        
                        Info.UpdateGold(Gold);
                    }
                    if (TownAnswer == "Armor")
                    {
                        Gold = Gold - 100;
                        Console.WriteLine(Gold);
                        Info.UpdateGold(Gold);
                    }
                    if (TownAnswer == "Consumables")
                    {
                        Console.WriteLine("Which items do you want to purchase?");
                        Console.WriteLine("[Bandages, Package, Whiskey]");
                        string ItemAnswer = Console.ReadLine();
                        if(ItemAnswer == "Bandages")
                        {
                            Gold = Gold - 100;
                            Console.WriteLine(Gold);
                            Info.UpdateGold(Gold);
                            //
                            Bandages = Bandages + 1;
                            Console.WriteLine(Bandages);
                            Info.UpdateBandages(Bandages);
                        }
                        if (ItemAnswer == "Package")
                        {
                            Gold = Gold - 100;
                            Console.WriteLine(Gold);
                            Info.UpdateGold(Gold);
                        }
                        if (ItemAnswer == "Whiskey")
                        {
                            Gold = Gold - 100;
                            Console.WriteLine(Gold);
                            Info.UpdateGold(Gold);
                        }
                    }
                    if (TownAnswer == "Library")
                    {
                        INTELLIGENCE = INTELLIGENCE + 1;
                        Console.WriteLine(INTELLIGENCE);
                        Info.UpdateINTELLIGENCE(INTELLIGENCE);
                    }
                }
                if (Answer == "Patrol")
                {
                    HP = HP - 1;
                    Console.WriteLine(HP);
                    Info.UpdateHP(HP);
                }
                if (Answer == "Guard")
                {
                    Gold = Gold + 100;
                    Console.WriteLine(Gold);
                    Info.UpdateGold(Gold);
                }
                if (Answer == "Rest")
                {
                    HP = HP + 1;
                    Console.WriteLine(HP);
                    Info.UpdateHP(HP);
                }
                if (Answer == "Train")
                {
                    STRENGTH = STRENGTH + 1;
                    Console.WriteLine(STRENGTH);
                    Info.UpdateSTRENGTH(STRENGTH);
                }
                if (Answer == "Drill")
                {
                    AGILITY = AGILITY + 1;
                    Console.WriteLine(AGILITY);
                    Info.UpdateAGILITY(AGILITY);
                }
                if (Answer == "Stats")
                {
                    Console.WriteLine("Str: {0} Int:{1} Agi: {2}", STRENGTH, INTELLIGENCE, AGILITY);
                }
                if (Answer == "Break")
                {
                    break;
                }
            }
        }
    }
}
