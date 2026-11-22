using InterfaceDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Classes
{
    public class Warrior : ICombatant
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks with a sword for {AttackPower} damage.");
        }

        public void Defend()
        {
            Console.WriteLine($"{Name} raises a shield to defend.");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage. Current health: {Health}");
        }
    }
}


