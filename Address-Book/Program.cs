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
                try
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
                            operation.NumOfPerson();
                            break;
                        case 9:
                            operation.SortByPersonName();
                            break;
                        case 10:
                            operation.SortByState();
                            break;
                        case 11:
                            operation.CONVERT_TO_TEXT();
                            break;
                        case 12:
                            operation.CONVERT_TO_CSV();
                            break;
                        case 13:
                            operation.CONVERT_TO_JSON();
                            break;
                        case 14:
                            System.Environment.Exit(0);
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

