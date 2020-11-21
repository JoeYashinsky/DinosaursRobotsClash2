using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robos_and_Dinos_Practice_Proj
{
    class Weapon
    {
        //member variables (HAS A)
        public string type;
        public int attackPower;


        // constructor (SPAWNER)
        public Weapon(string type)                      //the type of weapon can be passed in, just like name for robot
        {
            this.type = type;
            Random randomNumber = new Random();         //declared an instance of the Random class, and then below generating a rand number between 10 and 20. 
            attackPower = randomNumber.Next(10, 21);    //// then storing that random # directly in the attackPower member variable.
        }



        // member methods (CAN DO)
    }
}
