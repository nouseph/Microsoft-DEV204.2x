using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Assessment
{
    class Student
    {
        //Private member variables
        private string firstName;
        private string lastName;
        private double gpa;

        //Public properties
        public string FirstName
        {
            get
            {
                return firstName;

            }
            set
            {
                firstName = value;

            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;

            }
        }
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

        public Student(string firstName, string lastName, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
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
       
    }

}

