using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Pillars_of_OOP
{
    public class Car : Vehicle
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsRunning { get; set; }


        // Constructor
        public Car()
        {
            Make = "Chrysler";
            Model = "PT Cruiser";
            Speed = 0;
            TopSpeed = 150;
            Cost = -1500;
            IsRunning = false;
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

        public static void HonkHorn()
        {
            Console.WriteLine("HONK!!!");
            Console.Beep();
        }

        public void Accelerate()
        {
            Speed += 5;
        }
    }
}
