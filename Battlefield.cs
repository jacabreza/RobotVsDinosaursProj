﻿using System;
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

    }
}
