using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrussianSoldier.Initialization__Start_Screen;
using ThePrussianSoldier;

namespace ThePrussianSoldier.TheChapters
{
    class Chapter_3
    {
        PrimaryInformation Info;

        public Chapter_3()
        {
        }

        public Chapter_3(PrimaryInformation info)
        {
            Info = info;
        }

        public void LastChapter()
        {
            string One = "After a long and grueling war, Prussia begins to overpower the French Empire. Now you stand in the midst of Paris,";
            string Two = "looking to occupy the city, under the Prussian Kingdom. Yet something is wrong, quite wrong indeed. And then you";
            string Three = "spot it, a man riding trought the streets and slaughtering all Germanic soldiers, it's Napoleon the Third.";
            string Four = "You stand and look around, seeing none around you left to fight this false Emporer. You take it upon yourself";
            string Five = "to end the reign of Napoleon the Third.";
            string Six = "After fighting for what feels like hours, the once mighty false Emporer falls to the ground, his lifeless body";
            string Seven = "being witnessed by recently arrived soldiers, while you scream from the top of your lungs, THE FALSE EMPORER IS DEAD.";
            string Eight = "Cheers erupt over your grand victory, a week or so later, you are honored by riding among the leaders of Prussia to";
            string Nine = "the Hall of Mirrors in Versailles. There, generals of the army give speeches, not of Prussia,  but of the";
            string Ten = "Germanic peoples. On that Day, Wilhelm the First, King of Prussia, was announced the Kaiser of GERMANY as a NATION of Germans.";
            Console.WriteLine("");
            for (int i = 0; i < One.Length; i++)
            {
                Console.Write(One[i]);
                System.Threading.Thread.Sleep(10);
            }
            Console.WriteLine("");
            for (int i = 0; i < Two.Length; i++)
            {
                Console.Write(Two[i]);
                System.Threading.Thread.Sleep(10);
            }
            Console.WriteLine("");
            for (int i = 0; i < Three.Length; i++)
            {
                Console.Write(Three[i]);
                System.Threading.Thread.Sleep(10);
            }
            Console.WriteLine("");
            for (int i = 0; i < Four.Length; i++)
            {
                Console.Write(Four[i]);
                System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine("");
            for (int i = 0; i < Five.Length; i++)
            {
                Console.Write(Five[i]);
                System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine("Two weapons lay infront of you. Which do you choose?");
            Console.WriteLine("[Prussian Sword / French Rifle");
            string FinalChoice= Console.ReadLine();
            Console.WriteLine("");

            if(FinalChoice == "Prussian Sword")
            {
                Console.WriteLine("");
                for (int i = 0; i < Six.Length; i++)
                {
                    Console.Write(Six[i]);
                    System.Threading.Thread.Sleep(10);
                }

                Console.WriteLine("");
                for (int i = 0; i < Seven.Length; i++)
                {
                    Console.Write(Seven[i]);
                    System.Threading.Thread.Sleep(10);
                }

                Console.WriteLine("");
                for (int i = 0; i < Eight.Length; i++)
                {
                    Console.Write(Eight[i]);
                    System.Threading.Thread.Sleep(10);
                }

                Console.WriteLine("");
                for (int i = 0; i < Nine.Length; i++)
                {
                    Console.Write(Nine[i]);
                    System.Threading.Thread.Sleep(10);
                }

                Console.WriteLine("");
                for (int i = 0; i < Ten.Length; i++)
                {
                    Console.Write(Ten[i]);
                    System.Threading.Thread.Sleep(10);
                }
                Console.WriteLine("");
            }
            if (FinalChoice == "French Rifle")
            {
                Console.WriteLine("It's a French rifle, are you an idiot? The rifle didn't have ammo.");
                Console.WriteLine("You ended up another Dead Prussian at the False Emporer's hand.");
            }

            
        }
    }
}
