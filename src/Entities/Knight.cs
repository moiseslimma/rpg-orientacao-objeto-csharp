using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType)
        : base(name, level, heroType)
        {

        }

        public Knight()
        {

        }
        public override string Attack()
        {
            return Name + " atacou com a sua espada!";
        }
    }
}