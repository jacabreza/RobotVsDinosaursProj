using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        // member variables (HAS A)
        public string type;
        public int health;
        public int energy;
        public int attackPower;
       

        // constructor (SPAWNER)

        public Dinosaur(string typeOfDinosaur)
        {
            this.type = typeOfDinosaur;
            health = 100;
            energy = 100;
            attackPower = 100;
            

        }

        // member methods (CAN DO)
        public void DinosaurAttack(Robot robot)
        {
            // dinosaurWeapon, attackPower, energyLevel, Robot and there health
            // dinosaur loses energy 

            robot.health -= attackPower;        
            
            // energy -= attackPower;

        }

    }

}
