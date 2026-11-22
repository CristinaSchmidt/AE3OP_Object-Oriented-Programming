using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Interfaces
{
    public interface ICharacter
    {
        string Name { get; set; }
        int Health { get; set; }

        void TakeDamage(int damage);
    }
}
