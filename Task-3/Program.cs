using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class Vehicle
    {
        public int Speed { get; set; }

        public Vehicle(int speed)
        {
            Speed = speed;
        }
        public abstract void DisplayInfo();
    }
    class Car : Vehicle
    {
        public string carcolour { get; set; }

        public Car(int speed, string carcolour) : base(speed)
        {
            this.carcolour = carcolour;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: Speed = {Speed} km/h, Car colour is = {carcolour}");
        }
    }

    class Bike : Vehicle
    {
        public string bikecolour { get; set; }

        public Bike(int speed, string bikecolour) : base(speed)
        {
            this.bikecolour = bikecolour;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Bike: Speed = {Speed} km/h, Bike colour is = {bikecolour}");
        }
    }
    class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }

        public Truck(int speed, int loadCapacity) : base(speed)
        {
            LoadCapacity = loadCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Truck: Speed = {Speed} km/h, Load Capacity = {LoadCapacity} tons");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(120,"Grey");
            car.DisplayInfo();

            Vehicle bike = new Bike(80, "Matte Black");
            bike.DisplayInfo();

            Vehicle truck = new Truck(90, 10);
            truck.DisplayInfo();

            Console.ReadLine();
        }
    }
}
