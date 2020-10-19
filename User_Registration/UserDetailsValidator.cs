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

        public bool ValidateFirstName(string fName) => Regex.IsMatch(fName, REGEX_NAME) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.Invalid_Name, "Invalid First Name");
        public bool ValidateLastName(string lName) => Regex.IsMatch(lName, REGEX_NAME) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.Invalid_Name, "Invalid Last Name");
        public bool ValidateEmail(string email) => Regex.IsMatch(email, REGEX_EMAIL) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.Invalid_Email, "Invalid Email");
        public bool ValidatePassword(string password) => Regex.IsMatch(password, REGEX_PASSWORD) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.Invalid_Password, "Invalid Password");
        public bool ValidateMobNo(string mobileNo) => Regex.IsMatch(mobileNo, REGEX_MOB_NO) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.Invalid_Mobile, "Invalid Mobile Number");

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
