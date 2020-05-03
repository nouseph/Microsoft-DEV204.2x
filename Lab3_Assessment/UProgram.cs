using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Assessment
{
    class UProgram
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
            public UProgram(string programname, Degree degreename)
            {
                ProgramName = programname;
                ProgramDegree = degreename;

            }

        }
    }
