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
        public Weapon dinosaurWeapon;

        // constructor (SPAWNER)

        public Dinosaur(string typeOfDinosaur, string nameOfWeapon)
        {
            this.type = typeOfDinosaur;
            health = 100;
            energy = 100;
            attackPower = 25;
            dinosaurWeapon = new Weapon(nameOfWeapon);

        }

        // member methods (CAN DO)
        public int DinosaurAttack(Robot robot)
        {
            // dinosaurWeapon, attackPower, energyLevel, Robot and there health
            // dinosaur loses energy 
            int result;

            result = robot.health - attackPower;            // OR robot.health -= attack;
            return result;

            
            // energy -= attackPower;

        }

    }

}
