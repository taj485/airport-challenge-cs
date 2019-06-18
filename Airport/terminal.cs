using System;
using System.Collections.Generic;

namespace Airport
{
    public class Terminal
    {
        // Instance Variables
        public int Capacity;
        public List<Object> Hanger;

        // Constructor Declaration of Class 
        public Terminal(int capacity = 10) {
            Hanger = new List <Object>();
            Capacity = capacity;
        }

        public void Land(Object plane) {
            Hanger.Add(plane);
        }
    }
}
