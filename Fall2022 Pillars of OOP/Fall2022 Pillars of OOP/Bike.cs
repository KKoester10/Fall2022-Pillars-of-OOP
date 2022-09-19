using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Pillars_of_OOP
{
    internal class Bike : Vehicle, IAudible, IColorable
    {
        // Properties
        public string Brand { get; set; }
        public string Color { get; set; }

        // Constructor - default
        // This outlines what our default bike loks like, this DOES NOT create a new bike
        public Bike()
        {
            Brand = "Schwinn";
            Speed = 0;
            TopSpeed = 50;
            Cost = 300;
        }

        // Methods
        // need to use the modifier of Override for implemting an abstract method 
        public override void ChangeCost(decimal cost)
        {
            Cost = cost;
        }
        public override string ToStringRepresention()
        {
            // Alternative to strign concatenation is string literals 
            // String literals 
            return $"Make: {Brand} \nTop Speed: {TopSpeed} \n Cost: {Cost}";

            //String Concatenation
            // return "Make: " + Make;
        }
        public void MakeSound()
        {
            Console.WriteLine("Ring!");
        }
        public void SetColor(string color)
        {
            Color = color;
        }
        public bool CompareColors(IColorable other)
        {
            return Color.Equals(other.Color);
        }
    }
}
