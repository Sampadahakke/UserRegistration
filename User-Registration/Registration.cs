using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration
{
    internal class Registration
    {
        //Creating method to check validation for first name
        public void FirstName()
        {
            Console.WriteLine("Enter the name = ");
            string name = Console.ReadLine();
            string Pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (ValidateName(name,Pattern))
                Console.WriteLine("The entered name is valid!!");
            else
                Console.WriteLine("Please enter the valid name..");
        }

        //Creating method to check validation for last name
        public void LastName()
        {
            Console.WriteLine("Enter the last name = ");
            string name = Console.ReadLine();
            string pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (ValidateName(name, pattern))
                Console.WriteLine("The entered last name is valid!!");
            else
                Console.WriteLine("Please enter the valid last name..");
        }

        //Creating method to check validation for email id
        public void EmailId()
        {
            Console.WriteLine("Enter the email id = ");
            string emailId = Console.ReadLine();
            string pattern = "^[A-Za-z0-9]{3,}([.][A-Za-z0-9]{3,})?[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2})?$";

            if (ValidateName(emailId, pattern))
                Console.WriteLine("The entered email id is valid!!");
            else
                Console.WriteLine("Please enter the valid email id..");
        }

        //Creating method to check validation for mobile number
        public void MobileNumber()
        {
            Console.WriteLine("Enter the mobile number = ");
            string mobileNumber = Console.ReadLine();
            string pattern = "^([0-9]{2}[ ]){0,1}[0-9]{10}$";

             if (ValidateName(mobileNumber, pattern))
                Console.WriteLine("The entered mobile number is valid!!");
            else
                Console.WriteLine("Please enter the valid mobile number..");
        }

        //Creating method to check validation
        public bool ValidateName(string info, string Pattern)
        {
           return Regex.IsMatch( info, Pattern);
        }

    }
}
