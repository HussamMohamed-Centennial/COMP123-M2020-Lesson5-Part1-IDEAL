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

        //PUBLIC OPERATORS OVERLOADS
        public static Vector2D operator +(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x + rhs.x;
            float Ys = lhs.y + rhs.y;
            return new Vector2D(Xs,Ys);
        }
        public static Vector2D operator -(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x - rhs.x;
            float Ys = lhs.y - rhs.y;
            return new Vector2D(Xs, Ys);
        }
        public static Vector2D operator *(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x * rhs.x;
            float Ys = lhs.y * rhs.y;
            return new Vector2D(Xs, Ys);
        }
        public static Vector2D operator /(Vector2D lhs, Vector2D rhs)
        {
            float Xs = lhs.x / rhs.x;
            float Ys = lhs.y / rhs.y;
            return new Vector2D(Xs, Ys);
        }
        public static Vector2D operator *(Vector2D lhs, float x)
        {
            float Xs = lhs.x * x;
            float Ys = lhs.y * x;
            return new Vector2D(Xs, Ys);
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

        //PUBLIC STATIC METHODS
        public static Vector2D Zero()
        {
            return new Vector2D(0.0f ,0.0f);
        }

        public static Vector2D Up()
        {
            return new Vector2D(0.0f ,1.0f);
        }

        public static Vector2D Down()
        {
            return new Vector2D(0.0f, -1.0f);
        }

        public static Vector2D Right()
        {
            return new Vector2D(1.0f, 0.0f);
        }

        public static Vector2D Left()
        {
            return new Vector2D(-1.0f, 0.0f);
        }

        public static float Dot(Vector2D lhs, Vector2D rhs)
        {
            return (lhs.x * rhs.x) + (lhs.y * rhs.y);
        }

        public static float Distance(Vector2D lhs, Vector2D rhs)
        {
            float diffxs = rhs.x - lhs.x;
            float diffys = rhs.y - lhs.y;

            return Convert.ToSingle(Math.Sqrt(diffxs * diffxs + diffys * diffys)) ;
        }

    }
}
