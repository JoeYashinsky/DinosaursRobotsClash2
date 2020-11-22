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


        }

    }
}
