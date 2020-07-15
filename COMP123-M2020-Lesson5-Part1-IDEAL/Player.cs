using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1_IDEAL
{
    class Player : GameObject
    {
        //PRIVATE INSTANCE VARIABLES

        //PUBLIC PROPERTIES

        //CONSTRUCTORS
        public Player() 
            : base("Player")
        {
        }

        // PRIVATE METHODS

        // PUBLIC METHODS 
        public void RaiseSheild()
        {
            Console.WriteLine("Raising Sheilds");
        }
    }
}
