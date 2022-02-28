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
        //Initializing Variables
        public static string namePattern = "^[A-Z][a-zA-Z]{2,}$";
        string Name;  
        
        //Creating method to take user info
        public void UserInfo()
        {
            Console.Write("Enter the name = ");
            this.Name = Console.ReadLine();
        }

        //Creating method to check validation
        public bool ValidateName()
        {
           return Regex.IsMatch(Name, namePattern);
        }

    }
}
