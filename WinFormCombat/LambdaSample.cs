using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormCombat
{
   public class LambdaSample
    {
        public List<Stats> Statistics;

        
       

        public LambdaSample()
        {
            Statistics = new List<Stats>();
        }

        /// <summary>
        /// Sorts which of the following of i and j are assinged a higher speed statistic.
        /// </summary>
        public void AddCharacterStats()
        {
            Statistics.Sort((i, j) => i.Speed.CompareTo(j.Speed));
        }

    }

}




