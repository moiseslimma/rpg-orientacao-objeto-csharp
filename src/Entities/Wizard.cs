using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) 
       : base(name, level, heroType)
        {

        }
        public Wizard()
        {

        }
        public override string Attack()
        {
            return Name + " lançou magia";
        }
        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return Name + " lançou magia super efetiva com bônus de ataque de " + Bonus;
            }
            else
            {
                return Name + " lançou magia fraca com bônus de ataque de " + Bonus;
            }
        }
    }
}