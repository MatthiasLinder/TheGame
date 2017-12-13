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
        static int Gold;
        static int HP;
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
            
            //The game initiates from scratch...

            if (FirstAction == "Start")
            {
                //The 1-st Chapter begins...

                //var ToThe1stFight = new Chapter1Combat();
                //var PrimaryInformation = new PrimaryInformation();
                //var Gold = PrimaryInformation.Gold;

                //ENTER THE CHOICE SCREEN.
                var h = new PrimaryInformation();
                var ToTheChoiceScreen1 = new TheChoiceScreen(h);
                ToTheChoiceScreen1.Choices();
                Gold = h.GetGold();
                Console.WriteLine(Gold);

                
                HP = h.GetHP();
                Console.WriteLine(HP);
                //Enter Combat
                var enterCombat = new TheCombatSystem(h);
                enterCombat.Combat();


                var StartGame = new Chapter_1();

                ToTheChoiceScreen1.Choices();
            }






        }




    }

    
}

