using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrussianSoldier.Initialization__Start_Screen
{
    class PrimaryInformation
    {
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
    }
}
