using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class UserDetailsValidator
    {
        public static string fName;
        public static string REGEX_FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public void ValidateFirstName()
        {
            Console.WriteLine("Enter first name");
            fName = Console.ReadLine();
            bool validity = Regex.IsMatch(fName, REGEX_FIRST_NAME);
            if (!validity)
            {
                Console.WriteLine("Invalid input! First name must contain uppercase first letter and minimum 3 characters");
                ValidateFirstName();
            }
        }
        public void Display()
        {
            Console.WriteLine("FirstName : " + fName);
        }
    }
}
