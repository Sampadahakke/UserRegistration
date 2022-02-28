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

            //Creating object of class
            Registration registration = new Registration();
            registration.UserInfo();
            if(registration.ValidateName())
            {
                Console.WriteLine("The entered name is valid");
            }
            else
                Console.WriteLine("Please enter the valid name");
            Console.ReadKey();
        }

    }
}
