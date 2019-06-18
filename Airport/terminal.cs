using System;


namespace Airport
{
    public class Terminal
    {
        // Instance Variables
        public int Capacity { get; protected set; }
  
        // Constructor Declaration of Class 
        public Terminal(int capacity) {
            Capacity = capacity;
        }
    }
}
