﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Assessment
{
    class Uprogram
    {
        //Defining private member variables

        private string programName;
        private Degree programDegree;

        //Public properties

        public string ProgramName
        {
            get
            {
                return programName;
            }
            set
            {
                programName = value;
            }
        }

        public Degree ProgramDegree
        {
            get
            {
                return programDegree;

            }
            set
            {
                programDegree = value;

            }
        }

        //Defining constructor
        public Uprogram(string programname, Degree degreename)
        {
            ProgramName = programname;
            ProgramDegree = degreename;

        }
    }
}
