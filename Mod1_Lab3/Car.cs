using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Lab3
{
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
