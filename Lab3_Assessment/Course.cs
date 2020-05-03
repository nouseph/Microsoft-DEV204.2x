using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Assessment
{
    class Course
    {
        //Private member variables

        private string courseName;

        private string duration;
        private Student[] students;
        private Teacher[] teachers;


        //Defining public properties

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }
        public string Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;

            }
        }
        //Defining constructor

        public Course(string coursename, string courseduration)
        {
            Duration = courseduration;
            CourseName = coursename;
            students = new Student[maxArray];
            teachers = new Teacher[maxArray];


        }
        private int studentCount = 0;
        private int teacherCount = 0;
        private static int maxArray = 3;


        public int StudentCount
        {
            get
            {
                return studentCount;

            }
        }

        public int TeacherCount
        {
            get
            {
                return teacherCount;

            }
        }
        //Method to add students

        public void AddStudent(Student student)
        {
            int n = studentCount;
            if (n < maxArray)
            {
                students[n] = student;
                studentCount++;

            }
        }
        //Method to add teacher

        public void AddTeacher(Teacher teacher)
        {
            int n = teacherCount;
            if (n < maxArray)
            {
                teachers[n] = teacher;
                teacherCount++;

            }
        }
    }
}

