using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormCombat
{
    public class Character
    {


        public Stats CharStats;
        public string Name;



        public Character() { }

        public Character(Stats charStats, string name)
        {
            CharStats = charStats;
            Name = name;
        }

     
        public void Attack(Character a)
        {
            int tempHealth = a.CharStats.Health;
            a.CharStats.Health -= CharStats.Strength;
            if (0 != (a.CharStats.Luck % 2) || 0 != (a.CharStats.Luck % 5))
            {
                a.CharStats.Health = tempHealth;
                a.CharStats.Luck = (a.CharStats.Luck - 1);
            }
        }

        // Needs adjustments
        public void Defend(Character d)
        {
            d.CharStats.Health += (CharStats.Defense / 2);
        }




    }
}
