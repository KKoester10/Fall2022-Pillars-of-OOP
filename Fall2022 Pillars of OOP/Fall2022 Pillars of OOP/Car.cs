using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Pillars_of_OOP
{
    //if want to user more than one implemetation use ','
    internal class Car : Vehicle,IAudible, IComparable<Car>, IColorable
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        // Constructor
        public Car()
        {
            Make = "Chrysler";
            Model = "PT Cruiser";
            Speed = 0;
            TopSpeed = 150;
            Cost = -1500;
        }

        // Methods

        public void ChangeMake(string make)
        {
            Make = make;
        }
        public override void ChangeCost(decimal cost)
        {
            Cost = cost;
        }
        public override string ToStringRepresention()
        {
            // Alternative to strign concatenation is string literals 
            // String literals 
            return $"Make: {Make} \nModel: {Model}\nTop Speed: {TopSpeed}";


            //String Concatenation
            // return "Make: " + Make;
        }

        public void MakeSound()
        {
            Console.WriteLine("HONK!!!");
            Console.Beep();
        }

        public int CompareTo(Car? other)
        {
            throw new NotImplementedException();
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
