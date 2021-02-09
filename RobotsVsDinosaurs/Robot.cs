using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot
    //Variables
    {
        public string nameUnit;
        public int durability;
        public int powerLevel;
        public Weapon weapon; // WHO AMI !?!?!?!

        public Robot(string nameUnit, int durability, int powerLevel)
        {
            this.nameUnit = nameUnit;
            this.durability = durability;
            this.powerLevel = powerLevel;
            this.weapon = new Weapon("Laser Cutter", 10);
            
        }

        

        //Methods
        public void Engage(Dinosaur dinosaur) // what parameter should I pass in here?
        {
            
        }














    }
}
