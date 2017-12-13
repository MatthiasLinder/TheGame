using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrussianSoldier.Initialization__Start_Screen
{
    class PrimaryInformation
    {
        //GOLD
        public int Gold { get; set; }
        public int GetGold()
        {
            return Gold;
        }
        public PrimaryInformation()
        {
           
        }
        public void UpdateGold(int gold)
        {
            Gold = gold;
        }

        //HEALTH
        public int HP { get; set; }
        public int GetHP()
        {
            return HP;
        }
        public void UpdateHP(int hp)
        {
            HP = hp;
        }

        //STRENGTH
        public int STRENGTH { get; set; }
        public int GetSTRENGTH()
        {
            return STRENGTH;
        }
        public void UpdateSTRENGTH(int strength)
        {
            STRENGTH = strength;
        }
        //INTELLIGENCE
        public int INTELLIGENCE { get; set; }
        public int GetINTELLIGENCE()
        {
            return INTELLIGENCE;
        }
        public void UpdateINTELLIGENCE(int intelligence)
        {
            INTELLIGENCE = intelligence;
        }
        //AGILITY
        public int AGILITY { get; set; }
        public int GetAGILITY()
        {
            return AGILITY;
        }
        public void UpdateAGILITY(int agility)
        {
            AGILITY = agility;
        }

        // // // // // // // //
        // // // ITEMS // // //
        // // // // // // // //

        public int Bandages { get; set; }
        public int GetBandages()
        {
            return Bandages;
        }
        public void UpdateBandages(int bandages)
        {
            Bandages = bandages;
        }
    }
}
