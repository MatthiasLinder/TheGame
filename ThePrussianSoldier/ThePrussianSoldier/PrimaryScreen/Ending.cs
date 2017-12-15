using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrussianSoldier.PrimaryScreen
{
    class Ending
    {
        public Ending()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("███████ █████ █████   █         █    ██    █    █ █   █      █ ██████      █████ ██████ █   █ ██    █ ██    █████ ██   ");
            Console.WriteLine("█       █     █    █  ██       ██   █  █   ██   █  █ █       █ █           █     █    █ █   █ █ █   █ █ ██  █     █ ██ ");
            Console.WriteLine("█       █     █    █  █ █     █ █   █  █   █ █  █   █        █ ██████      ████  █    █ █   █ █  █  █ █   █ █     █   █");
            Console.WriteLine("█  ████ ████  █████   █  █   █  █  █    █  █  █ █   █        █      █      █     █    █ █   █ █   █ █ █   █ ███   █   █");
            Console.WriteLine("█     █ █     █    █  █   █ █   █ █ ████ █ █   ██   █        █      █      █     █    █ █   █ █    ██ █ ██  █     █ ██ ");
            Console.WriteLine("███████ █████ █     █ █    █    █ █      █ █    █   █        █ ██████      █     ██████ █████ █     █ ██    █████ ██   ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                        Congratulations, you have won the game of KAISERREICH.");
            Console.WriteLine("                     You will forever be remembered in the germanic halls of glory.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            Console.ReadKey();
            System.Environment.Exit(1);
        }

    }
}
