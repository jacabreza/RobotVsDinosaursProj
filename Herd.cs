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
        public Dinosaur dinosaurOne; 
        public Dinosaur dinosaurTwo;
        public Dinosaur dinosaurThree;

        public List<Dinosaur> listOfDinosaurs;

        // constructor (SPAWNER)
        public Herd()
        {
            listOfDinosaurs = new List<Dinosaur>();

            listOfDinosaurs.Add(new Dinosaur("dinosaurOne"));
            listOfDinosaurs.Add(new Dinosaur("dinosaurTwo"));
            listOfDinosaurs.Add(new Dinosaur("dinosaurThree"));

            //dinosaurOne = new Dinosaur("dinosaurOne");
            //dinosaurTwo = new Dinosaur("dinosaurTwo");
            //dinosaurThree = new Dinosaur("dinosaurThree");

        }

        // member methods (CAN DO)

    }
}
