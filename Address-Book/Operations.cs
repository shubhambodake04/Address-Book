using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Address_Book
{
    public class Operations
    {

        internal Dictionary<string, Contact> ContactLists = new Dictionary<string, Contact>();

        public void ADD_CONTACT()
        {
            try
            {
                Console.WriteLine("Enter First Name");
                string FirstName = Console.ReadLine();
                foreach (var Info in ContactLists)
                    if (FirstName.Equals(Info.Value.FirstName))
                    {
                        Console.WriteLine("This Contact is Already Added");
                        Console.ReadLine();
                    }
                Console.WriteLine("Enter LastName");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter City");
                string City = Console.ReadLine();
                Console.WriteLine("Enter State");
                string State = Console.ReadLine();
                Console.WriteLine("Enter Email");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter PhoneNumber");
                int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Zip");
                int Zip = Convert.ToInt32(Console.ReadLine());
                var newContact = new Contact(FirstName, LastName, Address, City, State, Email, PhoneNumber, Zip);
                ContactLists.Add(FirstName, newContact);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void SHOW_CONTACT()
        {
            foreach (var Info in ContactLists)
            {
                Console.WriteLine(Info.Value.FirstName + ", " + Info.Value.LastName + ", " + Info.Value.Address + ", " + Info.Value.City + ", " + Info.Value.State + ", " + Info.Value.Email + ", " + Info.Value.PhoneNumber + ", " + Info.Value.Zip);
            }

        }

        public void EDIT_CONTACT()
        {
            try
            {
                Console.WriteLine(" Enter Name Which You Want To Edit");
                string Name = Console.ReadLine();

                foreach (var Info in ContactLists)
                    if (Name.Equals(Info.Value.FirstName))
                    {
                        Console.WriteLine("Enter new FirstName");
                        string NewFirstName = Console.ReadLine();
                        Info.Value.FirstName = NewFirstName;
                        Console.WriteLine(" Edited Successfully");
                    }
                throw new Exception("Select Correct Name");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void DELETE_CONTACT()
        {
            try
            {
                Console.WriteLine("Enter First Name of the Contact you want to Delete:");
                string name = Console.ReadLine();
                foreach (var contact in ContactLists)
                    if (contact.Value.FirstName == name)
                    {
                        ContactLists.Remove(contact.Key);
                        Console.WriteLine("Deleted Successfully");
                    }
                throw new Exception("Select Correct Name");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void FIND_PERSON()
        {
            try
            {
                Console.WriteLine("Enter City:");
                string CityName = Console.ReadLine();

                foreach (var Info in ContactLists)
                    if (CityName.Equals(Info.Value.City))
                    {
                        Console.WriteLine("City:" + Info.Value.City + " ------ " + "FirstName:" + Info.Value.FirstName);

                    }
                throw new Exception("Please Enter Correct City Name");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void VIEW_PERSON()
        {
            try
            {
                Console.WriteLine("Enter Name of Person:");
                string Name = Console.ReadLine();

                foreach (var Info in ContactLists)
                    if (Info.Value.FirstName.Equals(Name))
                    {
                        Console.WriteLine("City:" + Info.Value.City + " ------ " + "FirstName:" + Info.Value.FirstName);

                    }
                throw new Exception("Please Enter Correct Person Name");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void COUNT()
        {
            Console.WriteLine("Total Number Of Contacts-- " + ContactLists.Count);

        }

        public void CONVERT_TO_TEXT()
        {
            FileIO.DataToTxt(ContactLists);
        }

        public void CONVERT_TO_CSV()
        {

            CSVHandler.DataToCSV(ContactLists);

        }


    }
}