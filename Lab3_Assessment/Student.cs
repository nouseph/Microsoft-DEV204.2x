using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Assessment
{
    class Student:Person
    {
        private double gpa;
        public double fee = 1500;


        public double Gpa
        {
            get
            {
                return gpa;

            }
            set
            {
                gpa = value;

            }
        }

        //Defining constructor

        public Student(string firstname, string lastname, double gpa)
        {
            firstName = firstname;
            lastName = lastname;
            Gpa = gpa;

            studentCount++;


        }
        //Declaring static variable to track number of students

        private static int studentCount = 0;

        //Declaring static member
        public static int CountStudents()
        {
            return studentCount;

        }
        public void TakeTest()
        {
            Console.WriteLine("The student {0} {1}  is taking the test .", firstName, lastName);

        }
        public override void GetFee()
        {
            Console.WriteLine($"The fee is {fee}.");


        }
    }

}
