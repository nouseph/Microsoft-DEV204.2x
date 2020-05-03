using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating employee object with name and salary
            //var employee1 = new Employee("Libby", 2000);
            var employee1 = new Employee("Libby",2000);
            //instantiating technicalemployee object 
            var employee2 = new TechnicalEmployee("Zaynah");
            //instantiating businessemployee object
            var employee3 = new BusinessEmployee("Winter");
            //output to the console window

            Console.WriteLine(employee1.employeeStatus() + 
                "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
            Console.ReadLine();

        }
    }
}
