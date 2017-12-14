using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePrussianSoldier.TheChapters;

namespace ThePrussianSoldier.Initialization__Start_Screen
{
    class Introduction_and_Character_Creation
    {
        public Introduction_and_Character_Creation()
        {
            string First = "O' Son of the Prussian Kingdom. The Kasier is dead, and his son is plagued by enemies from all sides.";
            string Second = "The actions of you and the army will define the fate of the Kaiserreich, and wether it will live for";
            string Third = "a thousand years, or fade into nothingness. Now write down your name in the army lists, and let us begin.";

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            for (int i = 0; i < First.Length; i++)
            {
                Console.Write(First[i]);
                System.Threading.Thread.Sleep(50);               
            }
            Console.WriteLine("");
            for (int i = 0; i < Second.Length; i++)
            {
                Console.Write(Second[i]);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("");
            for (int i = 0; i < Third.Length; i++)
            {
                Console.Write(Third[i]);
                System.Threading.Thread.Sleep(50);
            }
            
            Console.WriteLine("");

            Console.WriteLine("Enter your name.");
            string Name = Console.ReadLine();

            if (Name != null)
            {
               Console.WriteLine("Greetings {0}", Name);
               Console.WriteLine("Please enter your occupation.");
               string Occupation = Console.ReadLine();
               if (Occupation != null)
               {
                    //var CharacterCreation = new NewCharcater();
                    //StreamWriter File = new StreamWriter("C://Users//opilane//Desktop//GitHub//TheGame//PlayerInformation", true);
                    //Console.WriteLine("");
                    //File.WriteLine("Name: {0}", Name);
                    //File.WriteLine("Occupation: {0}", Occupation);
                    //File.Close();
                }
            }

            //var EnterTheChoiceScreen = new Chapter_1();
            

            //var Boi = new TheCombatSystem();
            //Console.WriteLine("You iz a winner");
            //var Boi2 = new TheCombatSystem();
        }
    }
}
