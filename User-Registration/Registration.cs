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
            Console.WriteLine("Enter the name = ");
            string name = Console.ReadLine();
            string Pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (ValidateName(name,Pattern))
                Console.WriteLine("The entered name is valid!!");
            else
                Console.WriteLine("Please enter the valid name..");
        }

        //Creating method to check validation
        public bool ValidateName(string info, string Pattern)
        {
           return Regex.IsMatch( info, Pattern);
        }

    }
}
