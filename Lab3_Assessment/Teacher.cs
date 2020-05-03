using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Assessment
{
    class Teacher:Person
    {
        private int age;
        public double salary = 50000;



        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        //Defining constructor

        public Teacher(string firstname, string lastname, int age)
        {
            firstName = firstname;
            lastName = lastname;
            Age = age;

        }



        public void GradeTest()
        {
            Console.WriteLine("The teacher {0} {1} is grading the test", firstName, lastName);

        }
        public override void GetSalary()
        {
            Console.WriteLine($"The salary is {salary}.");


        }
    }
}

  