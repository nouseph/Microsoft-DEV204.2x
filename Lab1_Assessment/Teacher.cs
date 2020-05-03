using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Assessment
{
    class Teacher
    {
        
       //Defining private member variables

       private string firstName;
       private string lastName;


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
       
       //Defining constructor

       public Teacher(string firstname,string lastname)
       {
           FirstName = firstname;
           LastName = lastname;


       }
       

    }
}
