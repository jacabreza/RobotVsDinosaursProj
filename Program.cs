using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {

            Battlefield battlefield = new Battlefield();
            battlefield.RunBattle();

            Console.ReadLine();
            //Robot robotOne = new Robot("RobotOne", "knife");
            //Robot robotTwo = new Robot("RobotTwo", "knife");
            //Robot robotThree = new Robot("RobotThree", "knife");

            //Dinosaur dinosaurOne = new Dinosaur("DinosaurOne", "Tail");
            //Dinosaur dinosaurTwo = new Dinosaur("DinosaurOne", "Tail");
            //Dinosaur dinosaurThree = new Dinosaur("DinosaurOne", "Tail");


        }
    }
}
