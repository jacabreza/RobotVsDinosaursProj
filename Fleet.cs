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

        public List<Robot> listOfRobots;

        // constructor (SPAWNER)
        public Fleet()
        {
            listOfRobots = new List<Robot>();

            listOfRobots.Add(new Robot("RobotOne", "knife"));
            listOfRobots.Add(new Robot("RobotTwo", "knife"));
            listOfRobots.Add(new Robot("RobotThree", "knife"));

            //robotOne = new Robot("RobotOne", "knife");
            //robotTwo = new Robot("RobotTwo", "knife");
            //robotThree = new Robot("RobotThree", "knife");

        }



        // member methods (CAN DO)

    }
}
