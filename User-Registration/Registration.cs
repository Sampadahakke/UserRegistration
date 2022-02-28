﻿using System;
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
            Console.Write("Enter the name = ");
            string name = Console.ReadLine();
            string Pattern = "^[A-Z][a-zA-Z]{2,}$";
            if (Validate(name,Pattern))
                Console.WriteLine("The entered name is valid!!");
            else
                Console.WriteLine("Please enter the valid name..");
        }

        //Creating method to check validation for last name
        public void LastName()
        {
            Console.Write("Enter the last name = ");
            string name = Console.ReadLine();
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            if (Validate(name, pattern))
                Console.WriteLine("The entered last name is valid!!");
            else
                Console.WriteLine("Please enter the valid last name..");
        }

        //Creating method to check validation for email id
        public void EmailId()
        {
            Console.Write("Enter the email id = ");
            string emailId = Console.ReadLine();
            string pattern = "^[A-Za-z0-9]{3,}([.][A-Za-z0-9]{3,})?[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2})?$";

            if (Validate(emailId, pattern))
                Console.WriteLine("The entered email id is valid!!");
            else
                Console.WriteLine("Please enter the valid email id..");
        }

        //Creating method to check validation
        public bool Validate(string info, string Pattern)
        {
           return Regex.IsMatch( info, Pattern);
        }

    }
}
