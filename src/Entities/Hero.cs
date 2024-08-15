using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Hp;
        public int Mp;
        public int Level;
        public string HeroType;

        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Hp = HowMuchHp(level);
            Mp = HowMuchMp(level);
            Level = level;
            HeroType = heroType;
        }
        public Hero() {

        }

        public override string ToString()
        {
            return Name + " | Level: " + Level + " | Hp: " + Hp + " | MP: " + Mp + " | Class: " + HeroType;
        }

        public virtual string Attack()
        {
            return Name + " atacou com a sua arma!";
        }
        private static int HowMuchHp(int level)
        {
            if(level < 5) return 100;
            if(level < 10) return 200;
            if(level < 15) return 300;
            if(level < 20) return 400;
            if(level < 25) return 500;
            return 550;
        }
        private static int HowMuchMp(int level)
        {
            if(level < 5) return 50;
            if(level < 10) return 100;
            if(level < 15) return 150;
            if(level < 20) return 200;
            if(level < 25) return 250;
            return 300;
        }
    }
}