using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Assessment
{
    //Defining abstract class

  abstract  class Person
    {
        
        public string firstName { get; set; }
        public string lastName { get; set; }
        public virtual void GetSalary()
        {

        }
        public virtual void GetFee()
        {

        }

        


    }
}
