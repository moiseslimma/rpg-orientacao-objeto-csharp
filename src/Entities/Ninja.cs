using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType)
        : base(name, level, heroType)
        {

        }

        public Ninja()
        {

        }
        public override string Attack()
        {
            return Name + " atacou com a sua kunai!";
        }
    }
}