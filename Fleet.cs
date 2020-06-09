using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        // member variables (HAS A)
        public Robot robotOne;
        public Robot robotTwo;
        public Robot robotThree;

        // constructor (SPAWNER)
        public Fleet()
        {
            robotOne = new Robot("RobotOne", "knife");               // member variables ex. name goes in parameters only if they are different
            robotTwo = new Robot("RobotTwo", "knife");               // member variables ex. name goes in parameters only if they are different
            robotThree = new Robot("RobotThree", "knife");           // member variables ex. name goes in parameters only if they are different

        }

        // member methods (CAN DO)

    }
}
