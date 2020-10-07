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
        public static string email;
        public static string mobNo;
        public static string password;

        public static string REGEX_FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string REGEX_LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string REGEX_EMAIL = "^[a-z]{2,}[.]?[a-z]{0,}@[a-z]{2,}.[a-z]{2,}[.]?[a-z]{0,}?";
        public static string REGEX_MOB_NO = @"^[1-9]{1}[0-9]{1}\s[1-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWORD = "(?=.*[A-Z])(?=.*[0-9]).{8,}";

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
        public void ValidateEmail()
        {
            Console.WriteLine("Enter email id");
            email = Console.ReadLine();
            bool validity = Regex.IsMatch(email, REGEX_EMAIL);
            if (!validity)
            {
                Console.WriteLine("Invalid email id !");
                ValidateEmail();
            }
        }
        public void ValidateMobNo()
        {
            Console.WriteLine("Enter Mobile number");
            mobNo = Console.ReadLine();
            bool validity = Regex.IsMatch(mobNo, REGEX_MOB_NO);
            if (!validity)
            {
                Console.WriteLine("Invalid Mobile number !");
                ValidateMobNo();
            }
        }
        public void ValidatePassword()
        {
            Console.WriteLine("Enter Password");
            password = Console.ReadLine();
            bool validity = Regex.IsMatch(password, REGEX_PASSWORD);
            if (!validity)
            {
                Console.WriteLine("Invalid Password !");
                ValidatePassword();
            }
        }
        public void Display()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("USER REGISTRATION DETAILS");
            Console.WriteLine("FirstName  : " + fName);
            Console.WriteLine("LastName   : " + lName);
            Console.WriteLine("Email id   : " + email);
            Console.WriteLine("Mobile no. : " + mobNo);
            Console.WriteLine("Password   : " + password);
        }
    }
}
