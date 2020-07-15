using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1_IDEAL
{
    class GameObject
    {
        // PRIVATE INSTANCE MEMBERS 
        private string m_name;

        // PUBLIC PROPERTIES
        public Transform Transform { get; set; }

        public string Name 
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

        // CONSTRUCTOR(S)
        public GameObject(string name)
        {
            Name = name;
        }

        // PRIVATE METHODS 


        // PUBLIC METHODS 

    }
}
