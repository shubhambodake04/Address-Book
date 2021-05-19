using System;
using System.Collections;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operation = new Operations();
            while (true)
            {
                Contact.Index();

                int Check = Convert.ToInt32(Console.ReadLine());
                switch (Check)
                {
                    case 1:
                        operation.ADD_CONTACT();
                        break;

                    case 2:
                        operation.SHOW_CONTACT();
                        break;

                    case 3:
                        operation.EDIT_CONTACT();
                        break;

                    case 4:
                        operation.DELETE_CONTACT();
                        break;

                    case 5:
                        operation.FIND_PERSON();
                        break;

                    case 6:
                        operation.VIEW_PERSON();
                        break;

                    case 7:
                        operation.COUNT();
                        break;

                    case 8:
                        System.Environment.Exit(0);
                        break;


                }
            }
        }
    }
}

