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


            herd.dinosaurOne.DinosaurAttack(fleet.robotOne);
            herd.dinosaurTwo.DinosaurAttack(fleet.robotTwo);
            herd.dinosaurThree.DinosaurAttack(fleet.robotThree);
            
            fleet.robotOne.RobotAttacks(herd.dinosaurOne);
            fleet.robotTwo.RobotAttacks(herd.dinosaurTwo);
            fleet.robotThree.RobotAttacks(herd.dinosaurThree);


        }
    }
}
