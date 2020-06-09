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

        // constructor (SPAWNER)
        public Herd()
        {
            dinosaurOne = new Dinosaur("dinosaurOne", "Tail");              // member variables ex. name goes in parameters only if they are different
            dinosaurTwo = new Dinosaur("dinosaurTwo", "Tail");              // member variables ex. name goes in parameters only if they are different
            dinosaurThree = new Dinosaur("dinosaurThree", "Tail");          // member variables ex. name goes in parameters only if they are different

        }

        // member methods (CAN DO)

    }
}
