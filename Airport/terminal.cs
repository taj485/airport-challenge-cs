using System;
using System.Collections.Generic;

namespace Airport
{
    public class Terminal
    {
        // Instance Variables
        public int Capacity;
        public List<string> Hanger;

        // Constructor Declaration of Class 
        public Terminal(int capacity = 10) {
            Hanger = new List <string>();
            Capacity = capacity;
        }

        public void Land() {
            
        }
    }
}
