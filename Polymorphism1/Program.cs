using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Vehicle
    {
        public int NumberOfWeels;
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Number of weels : {NumberOfWeels}");
        }
    }
    class Bike : Vehicle
    {
        public int MaxTopSpeed = 200;
        public override void PrintInfo()
        {
            Console.WriteLine($"Max top speed : {MaxTopSpeed}");
            
        }
    }
    class Car : Vehicle
    {
        public int NumberOfDoors = 5;
        public override void PrintInfo()
        {
            Console.WriteLine($"Number of doors : {NumberOfDoors}");
            Console.WriteLine($"Number of weels : {NumberOfWeels}");
        }
        public Car()
        {
            NumberOfWeels = 4;
        }
    }
    class Program
    {



        static void Main(string[] args)
        {
            List<Vehicle> list = new List<Vehicle>();
            list.Add(new Bike());
            list.Add(new Car());


            foreach (Vehicle item in list)
            {
                item.PrintInfo();
            }
        }
    }
}
