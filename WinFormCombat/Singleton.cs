using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormCombat
{
    public class Singleton
    {
        public static Singleton instance;

        public Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;

            }
        }

        public Stats CharStats;  // Does not work well with what is already in place and would 
                                 //take complete revision to fix which there is no time for.
                                 // attempted use in Character class

       
       
       
        public Character cOne; // Used in Form1 class
        public Character cTwo; // Used in Form1 class
       
    }
}
