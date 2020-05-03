using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab1
{
    //BusinessEmployee class inheriting from Employee
    class BusinessEmployee:Employee
    {
        //calls upon base class constructor from within derived class 
        //sets the basesalary to 50000 for all businessemployee objects

        public BusinessEmployee(string name) : base(name, 50000)
        {

        }
        //creates double variable called bonusbudget and assigns value to 1000
        public double bonusBudget = 1000;

        //this method returns toString() method which is employee's id and name and prints the bonus budget


        public override string employeeStatus()
        {
            return toString() + " with a budget of " + bonusBudget+".";

        }
    }
}
