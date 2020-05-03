using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab1
{
     class Employee
    {
        //3 private memeber variables:employeeNme,employeeBaseSalary and employeeId
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        //public properties

        public string Name
        {
            get 
            { 
                return employeeName;
            }
            set { 
                employeeName = value;
            }

        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;

            }
            set
            {
                employeeBaseSalary = value;

            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;

            }
        }
        //Creating a constructor
        public Employee(string name,double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
            ID = employeeCount++;


        }
        //method to return employees base salary

        public double getBaseSalary()
        {
            return BaseSalary;

        }
        //method to return employee name

        public string getName()
        {
            return Name;

        }
        //creates integer variable called employeeCount and assigns value to 1

        private static int employeeCount = 1;

        //method to return employee id
        public int getEmployeeID()
        {
            return ID;

        }
        //method returns the employee's id and name
        public string toString()
        {
            return ID + " " + Name;

        }
        //this method returns the employee's Id and name and confirms that the employee is in the system



        public virtual string employeeStatus()
        {
            return toString() + " is in the companys system";

        }
        
    }
}
