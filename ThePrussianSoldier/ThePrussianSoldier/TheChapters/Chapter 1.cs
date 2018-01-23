using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrussianSoldier.Initialization__Start_Screen;

namespace ThePrussianSoldier.TheChapters
{
    class Chapter_1
    {
        PrimaryInformation Info;
        public Chapter_1(PrimaryInformation info)
        {
            Info = info;
        }
        public void BeginnerChapter()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            string First = "The War begins between France and Prussia. You are sent to the front lines in service of the King of Prussia. ";
            string Second = "The Battlefield is fierce and large, spanning as far as the eye can see. The French may have more numbers in this particular battle, ";
            string Third = "but the Prussian way of organizing the army allows for small squads to operate semi autonomously on the battlefield.";
            string Fourth = "When came the time, to be organized into these squads, you were placed with the: [Scouts / Vanguard / Cavalry]";

            string Scouts = "...Scouts, due to the fact, that you were great unseen. ";
            string Vanguard = "...Vanguard, due to the fact, that you were always eager for battle in the name of his Majesty.";
            string Cavalry = "...Cavalry, due to your speed with a sword compared to others.";

            string Fifth = "Nevertheless, you are now deep within the battlefield, you see French soldiers around you cut their way trought the Germanic folk. ";
            string Sixth = "A group of the Soldiers spot your detachment, and rush for glory of their false Emporer. After a thundering roar of a French cannon,.";
            string Seventh = "you find yourself in a millitary infirmary. After being treated, you exit the infirmary to find yourself in a small Town.";

            for (int i = 0; i < First.Length; i++)
            {
                Console.Write(First[i]);
                System.Threading.Thread.Sleep(15);
            }
            Console.WriteLine("");
            for (int i = 0; i < Second.Length; i++)
            {
                Console.Write(Second[i]);
                System.Threading.Thread.Sleep(15);
            }
            Console.WriteLine("");
            for (int i = 0; i < Third.Length; i++)
            {
                Console.Write(Third[i]);
                System.Threading.Thread.Sleep(15);
            }
            Console.WriteLine("");
            for (int i = 0; i < Fourth.Length; i++)
            {
                Console.Write(Fourth[i]);
                System.Threading.Thread.Sleep(15);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            string Choice = Console.ReadLine();
            Console.WriteLine("");
            while (true)
            { 
             if (Choice != null)
             {
                if (Choice == "Scouts")
                {
                    for (int i = 0; i < Scouts.Length; i++)
                    {
                        Info.CMBT = 1;
                        Console.Write(Scouts[i]);
                        System.Threading.Thread.Sleep(15);
                    }
                    Console.WriteLine("");
                        break;
                    }
                if (Choice == "Cavalry")
                {
                    for (int i = 0; i < Cavalry.Length; i++)
                    {
                        Info.CMBT = 2;
                        Console.Write(Cavalry[i]);
                        System.Threading.Thread.Sleep(15);
                    }
                    Console.WriteLine("");
                        break;
                    }
                if (Choice == "Vanguard")
                {
                    for (int i = 0; i < Vanguard.Length; i++)
                    {
                        Info.CMBT = 3;
                        Console.Write(Vanguard[i]);
                        System.Threading.Thread.Sleep(15);
                    }
                    Console.WriteLine("");
                        break;
                }
                else
                {
                    Choice = Console.ReadLine();
                }
             }
            }
            for (int i = 0; i < Fifth.Length; i++)
            {
                Console.Write(Fifth[i]);
                System.Threading.Thread.Sleep(15);
            }
            Console.WriteLine("");
            for (int i = 0; i < Sixth.Length; i++)
            {
                Console.Write(Sixth[i]);
                System.Threading.Thread.Sleep(15);
            }
            Console.WriteLine("");
            for (int i = 0; i < Seventh.Length; i++)
            {
                Console.Write(Seventh[i]);
                System.Threading.Thread.Sleep(15);
            }
            Console.WriteLine("");
        }   }
}
