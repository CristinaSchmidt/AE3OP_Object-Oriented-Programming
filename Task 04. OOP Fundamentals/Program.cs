using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Classes;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount Compte1 = new BankAccount();

            try
            {
                Console.WriteLine("Quel est votre nom ?");
                Compte1.Name = Console.ReadLine();
                Console.WriteLine("Quel est votre solde ?");
                Compte1.Balance = Convert.ToDouble(Console.ReadLine());
            }
            catch(ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }

            Console.WriteLine(Compte1.Name);
            Console.ReadLine();
        }
    }
}
