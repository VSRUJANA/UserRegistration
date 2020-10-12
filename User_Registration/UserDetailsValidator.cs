using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class UserDetailsValidator
    {
        public static string firstName;
        public static string lastName;
        public static string eMail;
        public static string mobileNo;
        public static string passWord;

        public static string REGEX_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string REGEX_EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,4})?$";
        public static string REGEX_MOB_NO = @"^[1-9]{1}[0-9]{1}\s[1-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWORD = "(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).{8,}";

        public bool ValidateFirstName(string fName)
        {
            bool validity = Regex.IsMatch(fName, REGEX_NAME);
            firstName = fName;
            return validity;
        }
        public bool ValidateLastName(string lName)
        {
            bool validity = Regex.IsMatch(lName, REGEX_NAME);
            lastName = lName;
            return validity;
        }
        public bool ValidateEmail(string email)
        {
            bool validity = Regex.IsMatch(email, REGEX_EMAIL);
            eMail = email;
            return validity;
        }
        public bool ValidateMobNo(string mobNo)
        {
            bool validity = Regex.IsMatch(mobNo, REGEX_MOB_NO);
            mobileNo = mobNo;
            return validity;
        }
        public bool ValidatePassword(string password)
        {
            bool validity = Regex.IsMatch(password, REGEX_PASSWORD);
            passWord = password;
            return validity;
        }
        public void Display()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("USER REGISTRATION DETAILS");
            Console.WriteLine("FirstName  : " + firstName);
            Console.WriteLine("LastName   : " + lastName);
            Console.WriteLine("Email id   : " + eMail);
            Console.WriteLine("Mobile no. : " + mobileNo);
            Console.WriteLine("Password   : " + passWord);
        }
    }
}
