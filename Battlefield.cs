using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        // member variables (HAS A)
        public Herd herd;
        public Fleet fleet;

        // constructor (SPAWNER)
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }


        // member methods (CAN DO)
        public void RunBattle()
        {
            // use the DinosaurAttack() method to attack the Robots
            // use the RobotAttack() method to attakc the Dinosaurs

            bool teamIsStillAlive = false;
            while (!teamIsStillAlive)
            {
                fleet.listOfRobots[0].RobotAttacks(herd.listOfDinosaurs[0]);
                fleet.listOfRobots[1].RobotAttacks(herd.listOfDinosaurs[1]);
                fleet.listOfRobots[2].RobotAttacks(herd.listOfDinosaurs[2]);

                //herd.dinosaurOne.DinosaurAttack(fleet.robotOne);
                //herd.dinosaurTwo.DinosaurAttack(fleet.robotTwo);
                //herd.dinosaurThree.DinosaurAttack(fleet.robotThree);

                //fleet.robotOne.RobotAttacks(herd.dinosaurOne);
                //fleet.robotTwo.RobotAttacks(herd.dinosaurTwo);
                //fleet.robotThree.RobotAttacks(herd.dinosaurThree);

                if (herd.listOfDinosaurs.Count >= 0) 
                {
                    Console.WriteLine("Robots Win!");
                    teamIsStillAlive = !teamIsStillAlive;
                }
                else 
                {
                    Console.WriteLine("Dinosaur Win!");
                    teamIsStillAlive = !teamIsStillAlive;
                }
                Console.ReadLine();

            }

        }

    }
}
