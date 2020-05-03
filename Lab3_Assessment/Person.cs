using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Assessment
{
  abstract  class Person:IDisposable
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public virtual void GetSalary()
        {

        }
        public virtual void GetFee()
        {

        }
        //Destructor to perform additional application specific cleanup

        ~Person()
        {
            Dispose(false);

        }
        //Flag to check if object is disposed
        private bool disposed = false;
        StreamReader sr = null;


        public void ReadDetails(string fileName)
        {


            try
            {
                sr = new StreamReader(fileName);
                String contents = sr.ReadToEnd();
                Console.WriteLine("The file has {0} text elements", new StringInfo(contents).LengthInTextElements);



            }
            //Code to handle errors
       
             catch (FileNotFoundException)
            {
                Console.WriteLine("The file is not found");

            }
            //Invoking dispose method
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
                
            }
           
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }
            disposed = true;
        }


    }
}
