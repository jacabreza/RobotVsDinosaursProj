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
        public Dinosaur()
        {
            
            Dinosaur dinosaurOne = new Dinosaur();
            dinosaurOne.type = "T-Rex";
            dinosaurOne.health = 100;
            dinosaurOne.energy = 10;
            dinosaurOne.attackPower = 10;

            Dinosaur dinosaurTwo = new Dinosaur();
            dinosaurTwo.type = "Raptor";
            dinosaurTwo.health = 100;
            dinosaurTwo.energy = 10;
            dinosaurTwo.attackPower = 10;

            Dinosaur dinosaurThree = new Dinosaur();
            dinosaurThree.type = "Pterodactyl";
            dinosaurThree.health = 100;
            dinosaurThree.energy = 10;
            dinosaurThree.attackPower = 10;


        }

        // member methods (CAN DO)

    }
}
