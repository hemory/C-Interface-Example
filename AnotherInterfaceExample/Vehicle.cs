using System;
namespace AnotherInterfaceExample
{
    public class Vehicle :IDrivable
    {


       
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public Vehicle(string brand = "No Brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"The {Brand} Moves at {Speed} per hour!");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} Stops from the {Speed} per hour speed!");
        }
    }
}
