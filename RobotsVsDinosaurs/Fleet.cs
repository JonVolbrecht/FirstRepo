using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {

        public List<Robot> robots;

        public Fleet()
        {
            robots = new List<Robot>();
            Robot robot1 = new Robot("CS101", 100, 100);
            Robot robot2 = new Robot("CS102", 100, 100);
            Robot robot3 = new Robot("CS103", 100, 100);
            // Add all three robots to the list
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);

        }



    }
    

}
