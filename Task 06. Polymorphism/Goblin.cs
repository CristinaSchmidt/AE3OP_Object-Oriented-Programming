using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMinigame.Classes
{
    internal class Goblin : Character
    {
        public Goblin(string name) : base(name, 60, 10) { }

        public override void PerformAttack(Character target)
        {
            Console.WriteLine($"{Name} slashes with a rusty dagger!");
            target.TakeDamage(AttackPower);

            Random r = new Random();

            if (r.Next(0, 100) < 30)
            {
                Console.WriteLine($"{Name} strikes a second time out of nowhere!");
                target.TakeDamage(AttackPower / 2);
            }
        }
    }
}
