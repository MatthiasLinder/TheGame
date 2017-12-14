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
        public void UpdateGold(int gold)
        {
            Gold = gold;
        }

        //BULLETS
        public int Bullets { get; set; }
        public int GetBullets()
        {
            return Bullets;
        }
        public void UpdateBullets(int bullets)
        {
            Bullets = bullets;
        }

        //STAMINA
        public int Stamina { get; set; }
        public int GetStamina()
        {
            return Stamina;
        }
        public void UpdateStamina(int stamina)
        {
            Stamina = stamina;
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

        public int Package { get; set; }
        public int GetPackage()
        {
            return Package;
        }
        public void UpdatePackage(int package)
        {
            Package = package;
        }

        public int Whiskey { get; set; }
        public int GetWhiskeys()
        {
            return Whiskey;
        }
        public void UpdateWhiskey(int whiskey)
        {
            Whiskey = whiskey;
        }

        // // // // // // // // // // // // //
        // // // CHAPTER DETERMINANT // // //
        // // // // // // // // // // // // //

        public int CPD { get; set; }
        public int GetCPD()
        {
            return CPD;
        }
        public void UpdateCPD(int cpd)
        {
            CPD = cpd;
        }

        // // // // // // // // // // // // //
        // // // CHAPTER DETERMINANT // // //
        // // // // // // // // // // // // //
        public int CMBT { get; set; }
        public int GetCMBT()
        {
            return CPD;
        }
        public void UpdateCMBT(int cmbt)
        {
            CMBT = cmbt;
        }
    }
}
