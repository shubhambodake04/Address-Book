using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public double PhoneNumber { get; set; }
        
        public double Zip { get; set; }
        public Contact(string FirstName, string LastName, string Address, string City, string State, string Email, double PhoneNumber, double Zip)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Zip = Zip;
           

        }
        public static void Index()
        {

            Console.WriteLine("Please Select Option");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Search Person Using City");
            Console.WriteLine("6. View City Using Person");
            Console.WriteLine("7. Total Number of Contacts in Address Book");
            Console.WriteLine("8. perform File I/O");
            Console.WriteLine("9. Convert to CSV");
            Console.WriteLine("10. Exit");

        }

    }
}
