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
        int Gold = 500;
        public int GetGold()
        {
            return Gold;
        }
        public TheChoiceScreen(PrimaryInformation info)
        {
            Info = info;
        }
        public void Choices()
        {
            int ChapterDeterminant = 0;

            while (ChapterDeterminant == 0)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You are marching along a lonely road, what do you do?");
                Console.WriteLine("[Town, Patrol, Guard, Rest, Train]");

                string Answer = Console.ReadLine();

                if (Answer == "Town")
                {
                    Console.WriteLine("What do you wish to purchase whilst in the Town?");
                    Console.WriteLine("[Weapons, Armor, Consumables]");
                    string TownAnswer = Console.ReadLine();
                    if (TownAnswer == "Weapons")
                    {
                        Gold = Gold - 100;
                        Console.WriteLine(Gold);                        
                        Info.UpdateGold(Gold);
                        break;
                    }
                    if (TownAnswer == "Armor")
                    {

                    }
                    if (TownAnswer == "Consumables")
                    {

                    }
                }
                if (Answer == "Patrol")
                {

                }
                if (Answer == "Guard")
                {

                }
                if (Answer == "Rest")
                {

                }
                if (Answer == "Train")
                {

                }
            }
        }
    }
}
