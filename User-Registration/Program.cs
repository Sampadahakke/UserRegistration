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
            Console.WriteLine("Enter the user info :  \n1.FirstName  \n2.LastName");
            Registration registration = new Registration();
            int choice =Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    registration.FirstName();
                    break;
            }
            Console.ReadKey();
        }

    }
}
