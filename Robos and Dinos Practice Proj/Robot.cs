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




        // constructor (SPAWNER)         
                                        
                                         
        public Robot(string name, string weaponType)               
        {                                                          
            this.name = name;                                     
            health = 100;
            powerLevel = 100;
            weapon = new Weapon(weaponType);                               //To give the Weapon weapon variable its initial value, can instantiate.
        }                                                                  //Because the weapon variable is a Weapon object, need to instantiate it so it can actually exist inside of the robot.

        //When a robot gets created, I'll pass in a name, a weaponType. When this constructor is called, pass in a string that this constructor will refer to as name.
        //Whatever string is passed in, it will be plugged into the member variable name of this being-created robot object.
        //The weaponType that gets passed into this constructor will actually be handed off to the Weapon constructor, and that string will be used for type of weapon.

        //The Weapon constructor now has a parameter (string type = pass in a string), so I need to make sure to fulfill all the requirements of that parameter. (anytime a method has a parameter)



        // member methods (CAN DO)
        public void Attack(Dinosaur dinoTarget)
        {
            dinoTarget.health -= weapon.attackPower;

        }




    }
}

// As a developer, I want a Robot to have a name, health, power level, and a Weapon with a type(i.e.sword) and attack power.