using System;
using System.Collections;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            while (true)
            {
                Contact.Index();
                int Check = Convert.ToInt32(Console.ReadLine());
                switch (Check)
                {
                    case 1:
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
                        int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Zip");
                        int Zip = Convert.ToInt32(Console.ReadLine());

                        list.Add(new Contact(FirstName, LastName, Address, City, State, Email , PhoneNumber, Zip));
                        break;

                    case 2:
                        foreach (Contact Info in list)
                        {
                            Console.WriteLine(Info.FirstName + ", " + Info.LastName + ", " + Info.Address + ", " + Info.City + ", " + Info.State + ", " + Info.PhoneNumber + ", " + Info.Zip + ", " + Info.Email);
                        }
                        break;

                    case 3:
                        Console.WriteLine(" Enter Name Which You Want To Edit");
                        string Name = Console.ReadLine();

                        foreach (Contact Info in list)
                            if (Name.Equals(Info.FirstName))
                            {
                                Console.WriteLine("Enter new FName");
                                string NewName = Console.ReadLine();
                                Info.FirstName = NewName;

                            }
                        Console.WriteLine(" Edited Successfully");
                        break;

                    case 4:
                        Console.WriteLine("Enter Name Which You Want To Delete");
                        string delete = Console.ReadLine();
                        Contact contact = null;

                        foreach (Contact Info in list)
                        {
                            if (Info.FirstName == delete)
                            {
                                contact = Info;
                              
                            }
                            list.Remove(contact);
                        }
                        Console.WriteLine(" Deleted Successfully");
                        break;


                    case 5:
                        System.Environment.Exit(0);
                        break;


                }
            }
        }
    }
}

