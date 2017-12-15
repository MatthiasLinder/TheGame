using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrussianSoldier.Initialization__Start_Screen;
using ThePrussianSoldier.TheChapters;
using WMPLib;

namespace ThePrussianSoldier
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = "Prussia - Preußens Gloria.mp3";
            myplayer.controls.play();
            myplayer.settings.setMode("loop", true);


            Console.WriteLine("|-----------------------------------------------------------|");
            Console.WriteLine("| █  █    ██     █  ████ ████ ███   ███   ████ █ ███ █    █ |");
            Console.WriteLine("| █ █    █  █    █  █    █    █  █  █  █  █    █ █   █    █ |");
            Console.WriteLine("| ██    █    █   █  ████ ██   ███   ███   ███  █ █   ██████ |");
            Console.WriteLine("| █ █   █____█   █     █ █    █  █  █  █  █    █ █   █    █ |");
            Console.WriteLine("| █  █ █      █  █  ████ ████ █   █ █   █ ████ █ ███ █    █ |");
            Console.WriteLine("|-----------------------------------------------------------|");

            Console.WriteLine("                       |---------|");
            Console.WriteLine("                       |Options :|");
            Console.WriteLine("                       |---------|");

            Console.WriteLine("");

            Console.WriteLine("                       |---------|");
            Console.WriteLine("                       |  Start  |");
            Console.WriteLine("                       |---------|");
            Console.WriteLine("                       |---------|");
            Console.WriteLine("                       |         |");
            Console.WriteLine("                       |---------|");
            Console.WriteLine("                       |---------|");
            Console.WriteLine("                       |  Exit   |");
            Console.WriteLine("                       |---------|");

            Console.WriteLine("Please enter the name of the Command, that you want to execute.");
            Console.WriteLine("Note: Please play in Fullscreen");
            Console.WriteLine("");
            string FirstAction = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            //The game initiates from scratch...
            var h = new PrimaryInformation();

            if (FirstAction == "Start")
            {
                //The 1-st Chapter begins...
                var BeginnerChapter = new Chapter_1(h);
                BeginnerChapter.BeginnerChapter();
                int GameInteger = 1;
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine("");

                //ENTER THE CHOICE SCREEN.
                var ToTheChoiceScreen1 = new TheChoiceScreen(h);
                var eC = new TheCombatSystem(h);
                ToTheChoiceScreen1.Choices();
                Console.Clear();
                while (GameInteger == 1)
                {
                    eC.Combat();
                    Console.Clear();
                    ToTheChoiceScreen1.Choices();
                }
            }
            if (FirstAction == "Exit")
            {
                Console.WriteLine("");
                Console.WriteLine("Okay, you filthy casual.");
                System.Environment.Exit(1);
            }
        }
    }
    
}

