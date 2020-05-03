using System;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class
            var Car1 = new Car();
            var Car2 = new Car("Red", 2008);
            var Car3 = new Car();
            var Car4 = new Car();
            //Using dot notation to call members on Car1

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
    //Declaring a class Car
    public class Car
    {
        //Defining properties

        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        //Adding constructor with parameters as color and year
        public Car(string color, int year)
        {
            Color = color;
            Year = year;
            instances++;
        }
        //Adding constructor with parameters as year and mileage

        public Car(int year, int mileage)
        {
            Year = year;
            Mileage = mileage;
            instances++;
        }
        public Car()
        {
            //Everytime constructor runs increment instances
            instances++;

        }

        //Creates int variable called instances and assigns value 0
        private static int instances = 0;
        //Declare static member

        public static int CountCars()
        {
            return instances;

        }

    }
}


