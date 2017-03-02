using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormCombat
{
    public class Stats
    {

        public int Health;
        public int Defense;
        public int Strength;
        public int Luck;
        public int Speed;


        public Stats() { }

        public Stats(int health, int defense, int strength, int luck, int speed)
        {
            Health = health;
            Defense = defense;
            Strength = strength;
            Luck = luck;
            Speed = speed;
        } 

    }
}
