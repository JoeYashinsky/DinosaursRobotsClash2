using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robos_and_Dinos_Practice_Proj
{
    class Fleet
    {
        //member variables (HAS A)
        public List<Robot> robots;



        // constructor (SPAWNER)
        public Fleet()
        {
            robots = new List<Robot>();       //make a new instance of the List. Otherwise, it would just be null to start. When Fleet is created, we want this List called 'robots' to exist.

            Robot robotOne = new Robot("Tinker", "rocket");
            Robot robotTwo = new Robot("Evers", "powerGlove");
            Robot robotThree = new Robot("Chance", "bat");
        }




        // member methods (CAN DO)
    }
}
