using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Classes
{

    internal class BankAccount
    {
        private string name;
        private double balance;

        public string Name
        {
            get { return name; }
            set 
            { 
                if (!string.IsNullOrWhiteSpace(value)) name = value;
                else throw new ArgumentException(nameof(value), "Name cannot be empty or whitespace.");
            }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0) balance = value;
                else throw new ArgumentException(nameof(value), "Balance cannot be negative.");
            }
        }


    }
}
