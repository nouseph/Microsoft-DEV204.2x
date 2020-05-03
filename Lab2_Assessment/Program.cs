using System;

namespace Lab2_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating 3 student objects

            var student1 = new Student("Mark", "George", 2.9);
            var student2 = new Student("Jim", "Thomas", 2.5);
            var student3 = new Student("Luke", "Paul", 3.5);

            int students = Student.CountStudents();
            //Console.WriteLine($"Number of students enrolled are {students}.");

            //Instantiating a teacher object

            var teacher1 = new Teacher("Jill", "Joseph",35);
            var teacher2 = new Teacher("Mary", "John",40);


            //Instantiating course object "Programming with c#"

            var course1 = new Course("Programming with C#", "20");

            //Adding 3 students to the course object

            course1.AddStudent(student1);
            course1.AddStudent(student2);
            course1.AddStudent(student3);


            //Adding teacher to course object
            course1.AddTeacher(teacher1);

            //Instantiating degree object

            var degree1 = new Degree("Bachelor", course1);

            //Instantiating uProgram object

            var uprogram1 = new UProgram("Information Technology", degree1);


            //O/p


            //Name of the program and degree it contains

            Console.WriteLine("The {0} program contains {1} degree.", uprogram1.ProgramName, degree1.DegreeName);
            //Name of the course in the degree
            Console.WriteLine("The {0} degree contains the course {1} .", degree1.DegreeName, course1.CourseName);


            //Number of students in the course

            Console.WriteLine("The {0} course contains {1} students.", course1.CourseName, course1.StudentCount);

            student1.TakeTest();
            teacher1.GradeTest();
            teacher1.GetSalary();
            student1.GetFee();








        }
    }
}
