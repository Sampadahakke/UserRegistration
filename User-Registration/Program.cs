using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To User Registration===========");
            Registration registration = new Registration();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nEnter the user info :  \n1.FirstName  \n2.LastName \n3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        registration.FirstName();
                        break;
                    case 2:
                        registration.LastName();
                        break;
                    case 3:
                        Console.WriteLine("Do you want to exit = Y/N");
                        char option = Convert.ToChar(Console.ReadLine());
                        if(option == 'Y')
                        {
                            flag = false;
                            Console.WriteLine("Exited");
                        }
                        else
                        {
                            flag = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
            Console.ReadKey();
        }

    }
}
