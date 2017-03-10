using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormCombat
{
    // Attempoted use of singletons with CharStats but did not work well and left a mess.
    public class Character
    {


        public Stats CharStats;
        public string Name;
        


        public Character() { }

        public Character(string name, Stats charStats)
        {
            CharStats = charStats;
            Name = name;
        }

        
        /// <summary>
        /// Attacks selected target if target's luck value is less than or equal
        /// </summary>
        /// <param name="a"></param>
        // Problem Characters can still attack despite having a health value of 0
        public void Attack(Character a)
        {
            int tempHealth = a.CharStats.Health;
            if (a.CharStats.Health <= 0)
            {
                a.CharStats.Health = 0;
            }
            else
            {
                a.CharStats.Health -= CharStats.Strength;
                if (a.CharStats.Luck > 0)
                {
                    a.CharStats.Health = tempHealth;
                    a.CharStats.Luck = (a.CharStats.Luck - 7);
                }
                if (a.CharStats.Luck <= 0)
                {
                    a.CharStats.Luck = 0;
                }
            }
        }



        public void Defend(Character d)
        {
            if (d.CharStats.Defense <= 0)
                d.CharStats.Defense = 0;
            else
            {
                d.CharStats.Defense -= 10;
                d.CharStats.Health += (CharStats.Defense / 2);
                if (d.CharStats.Defense <= 0)
                    d.CharStats.Defense = 0;
            }
        }




    }
}

