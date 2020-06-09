using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        // member variables (HAS A)
        public string name;
        public int health;
        public int powerLevel;
        public Weapon robotsWeapon;

        // constructor (SPAWNER)

        public Robot()
        {
            robotsWeapon = new Weapon();
            
            Robot robotOne = new Robot();
            robotOne.name = "RobotOne";
            robotOne.health = 10;
            robotOne.powerLevel = 1;
            

            Robot robotTwo = new Robot();
            robotTwo.name = "RobotThree";
            robotTwo.health = 10;
            robotTwo.powerLevel = 1;
            

            Robot robotThree = new Robot();
            robotThree.name = "RobotThree";
            robotThree.health = 10;
            robotThree.powerLevel = 1;
            


        }

        // member methods (CAN DO)

    }
}
