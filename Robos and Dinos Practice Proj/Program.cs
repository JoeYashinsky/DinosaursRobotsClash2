using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robos_and_Dinos_Practice_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();
            battlefield.FightToTheDeath();

            Console.ReadLine();
        }
    }
}


//Robots vs. Dinosaurs User Stories
//Using the concepts of OOP by creating classes and using objects (instances of those classes) to interact with each other, create a console application that will have robots and dinosaurs fight in a battle.
//User stories:

//(5 points): As a developer, I want to make a class for each of the following: Robot, Dinosaur, Fleet, Herd,
//Weapon, Battlefield.
//(10 points): As a developer, I want a Robot to have a name, health, power level, and a Weapon with a type(i.e.sword) and attack power.

//(10 points): As a developer, I want a Dinosaur to have a type, health, energy, and attack power.

//(10 points): As a developer, I want to instantiate three Robot objects and three Dinosaur objects and
//assign the appropriate values to all the objects.

//(10 points): As a developer, I want the created Robot objects to be stored in a Fleet and the created Dinosaur objects to be stored in a Herd.

//(10 points): As a developer, I want a Robot to have the ability to attack a Dinosaur and a Dinosaur to have the ability to attack a Robot on a Battlefield.

//(10 points): As a developer, I want a Robot / Dinosaur to lose health points(loss based on attack power) when another Robot / Dinosaur successfully attacks it.

//(10 points): As a developer, I want the battle to conclude once either all the robots in the Fleet have their health points reach zero or all of the dinosaurs in the Herd have their health points reach zero.

//Bonus points:
//(5 points): As a developer, I want a Robot to have the ability to choose from a List of different weapons that will be then assigned as its own weapon.
//(5 points): As a developer, I want a Dinosaur to have the ability to choose its attack type from an array of different attack types before attacking a Robot in battle.
//(2 points): As a developer, I want a Robot/Dinosaur to have their powerLevel/energy decrease by 10 every time they attack.
