using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMinigame.Classes
{
    internal class Mage : Character
    {
        private int mana;
        public int Mana
        {
            get { return mana; }
            set { mana = 50; }
        }

        public Mage(string name) : base(name, 80, 25) { }

        public override void PerformAttack(Character target)
        {
            if (Mana >= 20)
            {
                Mana -= 20;
                Console.WriteLine($"{Name} casts a massive Fireball at {target.Name}! (Mana left: {Mana})");
                target.TakeDamage(AttackPower);
            }
            else
            {
                Console.WriteLine($"{Name} is out of mana! They whack {target.Name} weakly with a staff.");
                target.TakeDamage(5);
            }
        }

    }
}

