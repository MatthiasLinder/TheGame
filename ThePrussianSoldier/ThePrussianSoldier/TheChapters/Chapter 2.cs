using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrussianSoldier.Initialization__Start_Screen;

namespace ThePrussianSoldier.TheChapters
{
    class Chapter_2
    {
        PrimaryInformation Info;
        public Chapter_2(PrimaryInformation info)
        {
            Info = info;
        }

        public Chapter_2()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            string One = "You've been hardened by the battles of the Franco-Prussian war, now you've even been given";
            string Two = "more pressing assignments, currently, you are deep behind the French lines, trying to make your way";
            string Three = "to a camp supplying the front with artillery and cannons.";

            string Four = "You decide to rush towards the French camp, making it there quickly, alas, because of the rush";
            string Five = "your other squadmates are tired and hungry. Which means that you have to go at the assignment alone.";

            string Six = "You decide to let the soldiers rest and gather their courage, after an hour or so, you march on.";
            string Seven = "You arrive at the French camp, well prepared and ready for conflict.";

            string Eight = "The French camp is large and wide, there are 2 main positions to be destroyed by your estimates.";
            string Nine = "The Artillery depot and the Commander's quaters. You are the most experienced fighter of the bunch of";
            string Ten = "sabouteours sent out and the commander's of the Camp may provide a lot of resistance should they be left unchecked.";
            string Additional = "Also, the Commander's quaters house the marksmen of the camp, being able to spot enemies from far away.";

            string Eleven = "You choose to head to the artillery depot, due to it housing a lot of resources usable by the enemy war effort.";
            string Twelve = "You arrive at the depot, only to hear the alarm sounding from the Commanders quaters and soldiers rushing to capture you.";
            string Thirteen = "You awake 2 weeks later at base, having disrupted the French, but doing no damage to their lines.";

            string Additional2= "You choose the Commander's quaters, due to it holding the commanders of the camp, while heading there you spot the marksmen";
            string Fourteen = "of the camp watching from the tall towers infront of the quaters. They would have surely spotted you at the artillery depot.";
            string Fifteen = "You make your way to the commander's tents, you decide to burn the tents, thus disabling them for good. You head back to base.";

            Console.WriteLine("");
            for (int i = 0; i < One.Length; i++)
            {
                Console.Write(One[i]);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("");
            for (int i = 0; i < Two.Length; i++)
            {
                Console.Write(Two[i]);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("");
            for (int i = 0; i < Three.Length; i++)
            {
                Console.Write(Three[i]);
                System.Threading.Thread.Sleep(50);
            }

            Console.WriteLine("");
            Console.WriteLine("[Head towards the camp ; Rest for a while]");
            string firstchoice =Console.ReadLine();
            Console.WriteLine("");

            if(firstchoice == "Head towards the camp")
            {
                Console.WriteLine("");
                for (int i = 0; i < Four.Length; i++)
                {
                    Console.Write(Four[i]);
                    System.Threading.Thread.Sleep(50);

                }
                Console.WriteLine("");
                for (int i = 0; i < Five.Length; i++)
                {
                    Console.Write(Five[i]);
                    System.Threading.Thread.Sleep(50);
                }
            }
            if(firstchoice == "Rest for a while")
            {
                Console.WriteLine("");
                for (int i = 0; i < Six.Length; i++)
                {
                    Console.Write(Six[i]);
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine("");
                for (int i = 0; i < Seven.Length; i++)
                {
                    Console.Write(Seven[i]);
                    System.Threading.Thread.Sleep(50);
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < Eight.Length; i++)
            {
                Console.Write(Eight[i]);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("");
            for (int i = 0; i < Nine.Length; i++)
            {
                Console.Write(Nine[i]);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("");
            for (int i = 0; i < Ten.Length; i++)
            {
                Console.Write(Ten[i]);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("");
            for (int i = 0; i < Additional.Length; i++)
            {
                Console.Write(Additional[i]);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("");
            Console.WriteLine("[The Artillery Depot ; The Commander's Quaters]");
            string secondchoice = Console.ReadLine();
            Console.WriteLine("");
            if(secondchoice == "The Artillery Depot")
            {
                Console.WriteLine("");
                for (int i = 0; i < Eleven.Length; i++)
                {
                    Console.Write(Eleven[i]);
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine("");
                for (int i = 0; i < Twelve.Length; i++)
                {
                    Console.Write(Twelve[i]);
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine("");
                for (int i = 0; i < Thirteen.Length; i++)
                {
                    Console.Write(Thirteen[i]);
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            if (secondchoice == "The Commander's Quaters")
            {
                Console.WriteLine("");
                for (int i = 0; i < Additional2.Length; i++)
                {
                    Console.Write(Additional2[i]);
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine("");
                for (int i = 0; i < Fourteen.Length; i++)
                {
                    Console.Write(Fourteen[i]);
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine("");
                for (int i = 0; i < Fifteen.Length; i++)
                {
                    Console.Write(Fifteen[i]);
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
