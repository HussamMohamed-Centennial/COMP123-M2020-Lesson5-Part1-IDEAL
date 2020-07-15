using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1_IDEAL
{
    class Transform
    {
        //PUBLIC INSTANCE VARIABLE
        public Vector2D postion;
        public Vector2D rotation;
        public Vector2D scale;


        //CONSTRUCTOR
        public Transform()
        {
            m_initalize();
        }

        //PRIVATE METHODS
        private void m_initalize()
        {
            postion = new Vector2D();
            rotation = new Vector2D();
            scale = new Vector2D();
        }

        /// <summary>
        /// This method formate the transform to each of it's componanat (postion,totation and sclae ) in string formate
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += $"Postion : " + postion.ToString() + "\n";
            outputString += $"Rotation: " + rotation.ToString() + "\n";
            outputString += $"Scale   : " + scale.ToString() + "\n";

            return outputString;


        }
    }
}
