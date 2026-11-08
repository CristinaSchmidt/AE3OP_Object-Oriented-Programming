using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace InheritanceMinigame.Classes
{
    internal class Character
    {
        #region Attributs

        private string name;
        private int health;
        private int maxHealth;
        private int attackPower;
        private bool isAlive;

        #endregion

        #region Getters et Setters

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }

        public int AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }

        public bool IsAlive
        {
            get { return Health>0; }
        }

        #endregion

        #region Constructeurs

        protected Character(string name, int health, int attackPower)
        {
            this.Name = name;
            this.Health = health;
            this.MaxHealth = health;
            this.AttackPower = attackPower;
        }

        #endregion

        #region Méthodes

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;

            if (Health < 0)
                Health = 0;

            Console.WriteLine($"{Name} takes {damage} damage! (HP: {Health}/{MaxHealth})");
        }

        public virtual void PerformAttack(Character target) 
        { 
        
        }

        #endregion

    }
}
