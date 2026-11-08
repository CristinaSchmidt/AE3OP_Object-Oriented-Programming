using InheritanceMinigame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMinigame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE INHERITANCE ARENA");
            Console.Write("Enter your hero's name: ");
            string heroName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(heroName))
                heroName = "Unknown Hero";

            Console.WriteLine("\nChoose your class:");
            Console.WriteLine("1. Warrior (High Health, Blocks Damage)");
            Console.WriteLine("2. Mage (Fragile, Deals Massive Fireball Damage)");
            Console.Write("Selection (1 or 2): ");
            string choice = Console.ReadLine();

            Character player;

            if (choice == "2")
                player = new Mage(heroName);
            else
                player = new Warrior(heroName);





            Queue<Character> dungeonEnemies = new Queue<Character>();

            Character e1 = new Goblin("Grub the Sneaky");
            Character e2 = new Goblin("Zib the Vile");
            Character e3 = new Dragon("Ignis the Flame-Bringer");

            dungeonEnemies.Enqueue(e1);
            dungeonEnemies.Enqueue(e2);
            dungeonEnemies.Enqueue(e3);

            Console.WriteLine($"{player.Name} enters the dungeon!");

            while (player.IsAlive && dungeonEnemies.Count > 0)
            {
                Character currentEnemy = dungeonEnemies.Peek();
                Console.WriteLine($"\n--------------------------------------------");
                Console.WriteLine($"💥 A wild {currentEnemy.GetType().Name} appears: {currentEnemy.Name}!");
                Console.WriteLine($"--------------------------------------------");

                while (player.IsAlive && currentEnemy.IsAlive)
                {
                    Console.WriteLine("\nPress ENTER to attack!");
                    Console.ReadLine();
                    player.PerformAttack(currentEnemy);

                    if (!currentEnemy.IsAlive)
                    {
                        Console.WriteLine($"You defeated {currentEnemy.Name}!");
                        dungeonEnemies.Dequeue();
                        break;
                    }

                    currentEnemy.PerformAttack(player);
                }
            }

            Console.WriteLine("\n--- END OF GAME ---");
            if (player.IsAlive)
                Console.WriteLine("CONGRATULATIONS! You cleared the dungeon and won the game!");
            else
                Console.WriteLine("YOU DID NOT SURVIVE! GAME OVER.");
            Console.WriteLine("========================================");

            Console.ReadLine() ;

        }
    }
}

