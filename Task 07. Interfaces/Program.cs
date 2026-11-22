using InterfaceDemo.Classes;
using InterfaceDemo.Interfaces;
using InterfacesDemo.Classes;
using InterfacesDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IAnimal[] animals = { new Dog(), new Cat() };

            foreach (var animal in animals)
            {
                animal.Speak();
            }

            Warrior warrior = new Warrior
            {
                Name = "Aragorn",
                Health = 100,
                AttackPower = 25
            };

            warrior.Attack();
            warrior.Defend();
            warrior.TakeDamage(10);

            ICombatant[] fighters =
            {
            new Warrior { Name = "Aragorn", Health = 100, AttackPower = 25 },
            new Mage { Name = "Merlin", Health = 80, AttackPower = 40 }
            };

            foreach (var fighter in fighters)
            {
                fighter.Attack();
                fighter.Defend();
                fighter.TakeDamage(15);
            }
            foreach (var fighter in fighters)
            {
                fighter.Attack();
                fighter.Defend();
            }

            Console.ReadLine();
        }
    }
}

