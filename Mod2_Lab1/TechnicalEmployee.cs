using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab1
{

    //TechnicalEmployee inhertiting from Employee class
    class TechnicalEmployee : Employee
    {
        //calls upon base class employee class constructor from within derived class technicalEmployee class
        //sets basesalary to 75000 for all Technical employee objects

        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }

        //creates integer variable called successfulcheckins and assigns value to 5
        public int successfulCheckIns = 5;
        //this mehod returns the tostring() method which is the employee's id number and name and prints the number of successful check ins the employee has had

        public override string employeeStatus()
        {
            return toString() + " has " + successfulCheckIns + " successful checkins.";

        }
    }
}