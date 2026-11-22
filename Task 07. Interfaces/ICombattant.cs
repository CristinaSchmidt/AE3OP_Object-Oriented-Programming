using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Interfaces
{
    public interface ICombatant : ICharacter
    {
        int AttackPower { get; set; }

        void Attack();
        void Defend();
    }
}
