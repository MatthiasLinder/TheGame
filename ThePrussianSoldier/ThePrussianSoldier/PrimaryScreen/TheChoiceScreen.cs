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
        public int Gold { get; set; }

        public TheChoiceScreen()
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
                    Console.WriteLine("[Weapons Salesman, Armorer, Apothecary]");
                    string TownAnswer = Console.ReadLine();
                    if(TownAnswer == "Weapons Salesman")
                    {
                        Gold = Gold - 100;
                        Console.WriteLine(Gold);
                        break;
                    }
                    if (TownAnswer == "Armorer")
                    {

                    }
                    if (TownAnswer == "Apothecary")
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
