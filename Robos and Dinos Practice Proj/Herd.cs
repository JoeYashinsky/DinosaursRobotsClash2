using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robos_and_Dinos_Practice_Proj
{
    class Herd
    {

        //member variables (HAS A)
        public List<Dinosaur> dinosaurs;               //making a List of Dinosaur objects. List called 'dinosaurs'



        // constructor (SPAWNER)
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();          //instantiating the List

            Dinosaur dinosaurOne = new Dinosaur("Jurassic Park Raptor in kitchen scene");        //declare 3 dinosaur objects, give them their values, then add them to the List 
            Dinosaur dinosaurTwo = new Dinosaur("Jurassic Park dino that killed Newman");
            Dinosaur dinosaurThree = new Dinosaur("Jurassic World giant dino in water");
            dinosaurs.Add(dinosaurOne);
            dinosaurs.Add(dinosaurTwo);
            dinosaurs.Add(dinosaurThree);
        }

        // member methods (CAN DO)
        
    }
}
