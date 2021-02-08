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

        public Weapon weapon;

        Random randomNumber;
        public Robot(string nameUnit, int durability, int powerLevel, string weapon)
        {
            this.nameUnit = nameUnit;
            this.durability = durability;
            this.powerLevel = powerLevel;
            this.weapon = weapon; //Figure out weapons

            
        }

        

        //Methods
        public void Engage()
        {
            
        }














    }
}
