using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string name, int level, string heroType)
        : base(name, level, heroType)
        {

        }

        public BlackWizard()
        {

        }
        public override string Attack()
        {
            return Name + " lançou magia";
        }
    }
}