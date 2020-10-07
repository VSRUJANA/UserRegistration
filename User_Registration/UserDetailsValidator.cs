using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class UserDetailsValidator
    {
        public static string fName;
        public static string lName;
        public static string REGEX_FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string REGEX_LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public void ValidateFirstName()
        {
            Console.WriteLine("Enter first name");
            fName = Console.ReadLine();
            bool validity = Regex.IsMatch(fName, REGEX_FIRST_NAME);
            if (!validity)
            {
                Console.WriteLine("Invalid input! First name must start with uppercase letter and contain minimum 3 characters");
                ValidateFirstName();
            }
        }
        public void ValidateLastName()
        {
            Console.WriteLine("Enter Last name");
            lName = Console.ReadLine();
            bool validity = Regex.IsMatch(lName, REGEX_LAST_NAME);
            if (!validity)
            {
                Console.WriteLine("Invalid input! Last name must start with uppercase letter and contain minimum 3 characters");
                ValidateLastName();
            }
        }

        public void Display()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("USER REGISTRATION DETAILS");
            Console.WriteLine("FirstName : " + fName);
            Console.WriteLine("LastName  : " + lName);

        }
    }
}
