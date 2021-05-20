using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Address_Book
{
    class Handler
    {
        const string TEXTPATH = @"C:\Users\Shubham\source\Address-Book\Address-Book\Utility\Example.txt";
        const string CSVPATH = @"C:\Users\Shubham\source\Address-Book\Address-Book\Utility\Example.csv";
        const string JSONPATH = @"C:\Users\Shubham\source\Address-Book\Address-Book\Utility\JSON.csv";
       
        public static void DataToTxt(Dictionary<string, Contact> ContactList)
        {
            if (File.Exists(TEXTPATH))
            {
                using (TextWriter tw = new StreamWriter(TEXTPATH))
                {
                    tw.WriteLine(string.Format("FirstName, LastName, Address, City, State, Email, PhoneNumber, Zip"));
                    foreach (var Info in ContactList)
                    {
                        tw.WriteLine(string.Format($"{Info.Value.FirstName},{Info.Value.LastName},{Info.Value.Address},{Info.Value.City},{Info.Value.State},{Info.Value.Email},{Info.Value.PhoneNumber},{Info.Value.Zip}"));
                    }
                }
            }
            else
                Console.WriteLine("File doesn't exist");
        }
        

    }
}
