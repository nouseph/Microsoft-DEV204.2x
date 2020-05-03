using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Assessment
{
    class Degree
    {
        //Defining private member variables
        private string degreeName;
        private Course courseName;

        //Defining public properties

        public string DegreeName
        {
            get
            {
                return degreeName;
            }
            set
            {
                degreeName = value;
            }
        }

        public Course CourseName
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
        //Defining constructor

        public Degree(string degreename,Course coursename)
        {
            CourseName = coursename;
            DegreeName = degreename;

        }

    }
}
