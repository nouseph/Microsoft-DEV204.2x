using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class
            var Car1 = new Car();
           
            Car1.Color = "White";
            Car1.Mileage = 11000;
            Car1.Year = 2010;
            
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
        
       
    }
}
