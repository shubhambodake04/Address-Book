using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Address_Book
{
    class FileIO
    {
        const string PATH = @"C:\Users\Shubham\source\Address-Book\Address-Book\Utility\Example.txt";
        public static void DataToTxt(Dictionary<string, Contact> ContactList)
        {
            if (File.Exists(PATH))
            {
                using (TextWriter tw = new StreamWriter(PATH))
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
