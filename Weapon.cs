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
        public int attackPower;

        // constructor (SPAWNER)
        public Weapon(string typeOfWeapon)
        {
            type = typeOfWeapon;
            attackPower = 100;
        }

        // member methods (CAN DO)

    }
}
