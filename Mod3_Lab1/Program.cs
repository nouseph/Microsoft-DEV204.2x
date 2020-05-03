using System;
using System.Globalization;
using System.IO;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating  StreamReader object
            // Assigns its value to null
            StreamReader streamReaderObject = null;

            try
            {
                // Assigning streamReaderObject to read from a file
                streamReaderObject = new StreamReader("file1.txt");

                // Reads all characters and stores in contents
                String contents = streamReaderObject.ReadToEnd();


                // Writes the amount of text elements in the text file to the Console
                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
            }

            // Code to handle any errors
            catch (FileNotFoundException)
            {
                // Informs user there is no file created
                Console.WriteLine("The file cannot be found.");
            }

            finally
            {
                // Checks if object is not null
                if (streamReaderObject != null)
                {
                    // Closing StreamReader
                    streamReaderObject.Close();

                    // Calling the Dispose method
                    streamReaderObject.Dispose();
                }

            }
        }
    }
}       
