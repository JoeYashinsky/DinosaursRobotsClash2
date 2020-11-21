using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robos_and_Dinos_Practice_Proj
{
    class Robot
    {
        //member variables (HAS A)
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;             //Declare a member variable of data type Weapon and call it weapon.




        // constructor (SPAWNER)         //this is where to set initial values for the member variables
        public Robot(string name)               //When this constructor is called, pass in a string that this constructor will refer to as name.
        {                                       //Whatever string is passed in, it will be plugged into the member  variable name of this being-created robot object.
            this.name = name;                       //if I hard coded the robot's name here as "Kevin," then all the robots would be named Kevin
            health = 100;
            powerLevel = 100;
            weapon = new Weapon();                                       //To give the Weapon weapon variable its initial value, can instantiate.
        }                               //Because the weapon variable is a Weapon object, need to instantiate it so it can actually exist inside of the robot.


        

        // member methods (CAN DO)




    }
}

// As a developer, I want a Robot to have a name, health, power level, and a Weapon with a type(i.e.sword) and attack power.