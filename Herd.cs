using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        // member variables (HAS A)
        public Dinosaur dinosaur;

        Dinosaur dinosaurOne = new Dinosaur();
        dinosaurOne.type = "T-Rex";
        dinosaurOne.health = 100;
        dinosaurOne.energy = 10;
        dinosaurOne.attackPower = 10;

        Dinosaur DinosaurTwo = new Dinosaur();
        DinosaurTwo.type = "Raptor";
        DinosaurTwo.health = 100;
        DinosaurTwo.energy = 10;
        DinosaurTwo.attackPower = 10;

        Dinosaur dinosaurThree = new Dinosaur();
        DinosaurThree.type = "Pterodactyl";
        DinosaurThree.health = 100;
        DinosaurThree.energy = 10;
        DinosaurThree.attackPower = 10;

        // constructor (SPAWNER)
        public Herd()
        {
            dinosaurThree = new Dinosaur("Pterodactyl", 100, 10, 10);



        }

        // member methods (CAN DO)

    }
}
