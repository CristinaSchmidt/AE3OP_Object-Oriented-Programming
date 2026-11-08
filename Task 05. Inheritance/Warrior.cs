using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMinigame.Classes
{
    internal class Warrior : Character
    {

        private int shieldBlock;


        public int ShieldBlock
        {
            get { return shieldBlock; }
            set { shieldBlock = 4; }
        }

        public Warrior(string nom) : base(nom,120,15)
        {

        }

        public override void PerformAttack(Character target)
        {
            Console.WriteLine($"{Name} swings a heavy greatsword at {target.Name}!");
            target.TakeDamage(AttackPower);
        }

        public override void TakeDamage(int damage)
        {
            int finalDamage = Math.Max(1, damage - ShieldBlock);
            Console.WriteLine($"{Name} blocks {ShieldBlock} damage with their shield!");
            base.TakeDamage(finalDamage);
        }

    }
}
