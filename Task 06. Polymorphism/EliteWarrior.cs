using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMinigame.Classes
{
    internal class EliteWarrior : Warrior
    {
        public EliteWarrior(string name) : base($"Elite Member {name}")
        {
            AttackPower *= 2;
            ShieldBlock *= 2;
        }

        /*public override void PerformAttack(Character target)
        {
            base.PerformAttack(target);
            Console.WriteLine($"{Name} strikes with elite power!");
        }*/

    }
}

//base is a reference to a parent 
//We are doing constructor chaining
