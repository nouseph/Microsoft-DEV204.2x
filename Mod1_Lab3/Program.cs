using System;

namespace Mod1_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class
            var Car1 = new Car();

            //Using dot notation to call members on Car1
            var Car2 = new Car("Red", 2008);
            var Car3 = new Car();
            var Car4 = new Car();

            Car1.Color = "White";
            Car1.Mileage = 11000;
            Car1.Year = 2010;
            //Access static members
            int carCount = Car.CountCars();
            Console.WriteLine($"There are {carCount} cars right now.");
            //O/p to the console window
            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year} with mileage of {Car1.Mileage} miles.");
        }
    }
}
    