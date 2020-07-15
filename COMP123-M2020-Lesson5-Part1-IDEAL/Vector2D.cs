using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1_IDEAL
{
    class Vector2D
    {
        //PUBLIC INSTANCE VARIABLES
        public float x;
        public float y;

        //CONSTRUCTOR


        /// <summary>
        /// This constructor take x and y as optional parameters 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector2D(float x = 0.0f, float y = 0.0f)
        {
            this.x = x;
            this.y = y;

        }


        //PUBLIC METHODS

        /// <summary>
        /// This methods return the values of x and y componanat with the formate (x,y) as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = $"({x}, {y})";
            return outputString;
        }
    }
}
