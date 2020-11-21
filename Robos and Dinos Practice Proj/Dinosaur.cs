using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robos_and_Dinos_Practice_Proj
{
    class Dinosaur
    {
        //member variables (HAS A)    (declaring the variables)
        public string type;        
        public int health;
        public int energy;
        public int attackPower;



        // constructor (SPAWNER)       (this is where I will assign the member variables their initial values)
        public Dinosaur()
        {
            this.type = type;
            health = 100;
            energy = 100;
            Random randomDinoNumber = new Random();
            attackPower = randomDinoNumber.Next(10, 21);

        }



        // member methods (CAN DO)


    }
}
