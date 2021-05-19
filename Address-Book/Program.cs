using System;
using System.Collections;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AdressBook");
            Console.WriteLine("<======================>");

            Console.WriteLine("Enter FirstName");
            string FirstName = Console.ReadLine();
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
            int PhoneNNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Zip");
            int Zip = Convert.ToInt32(Console.ReadLine());

            ArrayList list = new ArrayList();
            list.Add(new Contact(FirstName, LastName, Address, City, State, PhoneNNumber, Zip, Email));

            foreach (Contact Info in list)
            {
                Console.WriteLine(Info.FirstName + " , " + Info.LastName + " , " + Info.Address + " , " + Info.City + ", " + Info.State + ", " + Info.PhoneNumber + ", " + Info.Zip + ", " + Info.Email);
            }
        }
    }
}
