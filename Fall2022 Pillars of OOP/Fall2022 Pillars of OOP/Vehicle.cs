using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Pillars_of_OOP
{
    // adding in the abstract modifior to make this an abstract class
    // Abstraction - Making a generic class that can be inherited by children classes by lending functionality 
    internal abstract class Vehicle
    {
        //properties
        // when we use abstract on a property , we are declairing the getters and setters abstract, Not the property itself
        public int Speed { get; set; }
        public int TopSpeed { get; set; }
        public decimal Cost { get; set; }

        // methods
        // because we used the abstract key word, we were able to leave the implementation of theses methods out
        public abstract string ToStringRepresention();
        public abstract void ChangeCost(decimal cost);
        // but since we're in a class , we can implement methods if we'd like
        public static void Travel(int distance)
        {
            Console.WriteLine($"You traveled {distance} miles!");
        }
    }
}
