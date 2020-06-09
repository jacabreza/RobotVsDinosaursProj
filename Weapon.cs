using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        // member variables (HAS A)
        public string type;
        public int damage;

        // constructor (SPAWNER)
        public Weapon(string typeOfWeapon)
        {
            type = typeOfWeapon;
            damage = 10;
        }

        // member methods (CAN DO)

    }
}
