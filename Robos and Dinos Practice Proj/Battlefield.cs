using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robos_and_Dinos_Practice_Proj
{
    class Battlefield
    {
        //member variables (HAS A)
        public Fleet fleet;
        public Herd herd;



        // constructor (SPAWNER)
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }


        // member methods (CAN DO)
        public void FightToTheDeath()
        {
            while(herd.dinosaurs.Count > 0 && fleet.robots.Count > 0)
            {
                herd.dinosaurs[0].Attack(fleet.robots[0]);
                Console.WriteLine("Rumble in the jungle! Dinosaurs attack!");
            
                if(fleet.robots[0].health <= 0)
                {
                    fleet.robots.RemoveAt(0);
                    Console.WriteLine("Pour one out for that robot. RIP, robo-dude.");
                    if(fleet.robots.Count == 0)
                    {
                        break;
                    }    
                }
            
                fleet.robots[0].Attack(herd.dinosaurs[0]);
                Console.WriteLine("The robots have grabbed the momentum");
            
                if(herd.dinosaurs[0].health <= 0)
                {
                herd.dinosaurs.RemoveAt(0);
                    Console.WriteLine("That dino just died a slow death...like The Lost World's performance at the box office.");
                }
            }
            if(herd.dinosaurs.Count > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Life finds a way. Dinosaurs have won");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Robots are victorioous. Celebratory screening of 'I, Robot' later tonight!");
            }
            

        }

    }
}
