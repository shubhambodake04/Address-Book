using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Address_Book
{
    class CSVHandler
    {
       const string FILEPATH = @"C:\Users\Shubham\source\Address-Book\Address-Book\Utility\Example.csv";
        public void WriteDataToCSV(Dictionary<string, Contact> ContactList)
        {
            if (File.Exists(FILEPATH))
            {
                using (TextWriter tw = new StreamWriter(FILEPATH))
                {
                    tw.WriteLine(string.Format("FirstName,LastName,Address,City,State,Email,PhoneNumber,ZipCode"));
                    foreach (var Info in ContactList)
                    {
                        tw.WriteLine(Info.Value.FirstName + "," + Info.Value.LastName + "," + Info.Value.Address + "," + Info.Value.City + "," + Info.Value.State + "," + Info.Value.Email + "," + Info.Value.PhoneNumber + "," + Info.Value.Zip);
                    }
                }
            }
            else Console.WriteLine("File doesn't exist, Check the Path");
        }

        
    }
}
