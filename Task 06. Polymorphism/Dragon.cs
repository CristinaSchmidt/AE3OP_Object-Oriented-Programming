using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMinigame.Classes
{
    internal class Dragon : Character
    {
        public Dragon(string name) : base(name, 200, 20) { }

        public override void PerformAttack(Character target)
        {
            Console.WriteLine($"{Name} breathes devastating fire across the battlefield!");
            target.TakeDamage(AttackPower);
        }
    }
}
