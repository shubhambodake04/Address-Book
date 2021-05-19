using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class Contact
    {
        public string FirstName, LastName, Address, City, State, Email;
        public double PhoneNumber, Zip;

        public Contact(string FirstName, string LastName, string Address, string City, string State, double PhoneNumber, double Zip, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.PhoneNumber = PhoneNumber;
            this.Zip = Zip;
            this.Email = Email;

        }

    }
}
