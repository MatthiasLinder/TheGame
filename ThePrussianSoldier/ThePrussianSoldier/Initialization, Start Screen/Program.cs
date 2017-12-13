using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrussianSoldier.Cha;
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
            Console.WriteLine("                       |Load Game|");
            Console.WriteLine("                       |---------|");
            Console.WriteLine("                       |---------|");
            Console.WriteLine("                       |  Exit   |");
            Console.WriteLine("                       |---------|");

            Console.WriteLine("Please enter the name of the Command, that you want to execute.");
            Console.WriteLine("Note: Please play in Fullscreen");
            string FirstAction = Console.ReadLine();




            if (FirstAction == "Start")
            {




                //var ToThe1stFight = new Chapter1Combat();

                var PrimaryInformation = new PrimaryInformation();
                var GoldPrimary = PrimaryInformation.Gold;

                var ToTheChoiceScreen1 = new TheChoiceScreen();

                var StartGame = new Chapter_1();
                var hit = StartGame.HitPoints;

                var ToTheChoiceScreen2 = new TheChoiceScreen();
            }






        }




    }

    
}

