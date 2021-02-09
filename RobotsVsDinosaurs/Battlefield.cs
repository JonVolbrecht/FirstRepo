using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        // Declare a Herd and Fleet variables
        public Fleet fleet;
        public Herd herd;

        // Instantiate these variables in the constructor
        public Battlefield()
        {
            Fleet robots = new Fleet();
            Herd dinosaurs = new Herd();
        }

        // Build a Battle method that makes the robots in the fleets robots list attack the dinos in the herds dinos list until on of the teams completely die

        public void RunBattle()
        //Dinosaurs and Robots attacks need to reduce the health of the other calling the attack methods in their classes
        {
            Dinosaur.dinosaurs[0].Attack() = Fleet.[0];
        }
    }
}
