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
            try
            {
                if (fName.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "First Name should not be empty");
                }
                firstName = fName;
                return Regex.IsMatch(fName, REGEX_NAME);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "First Name should not be null");
            }
        }
        public bool ValidateLastName(string lName)
        {
            try
            {
                if (lName.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Last Name should not be empty");
                }
                lastName = lName;
                return Regex.IsMatch(lName, REGEX_NAME);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Last Name should not be null");
            }
        }
        public bool ValidateEmail(string email)
        {
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Email should not be empty");
                }
                eMail = email;
                return Regex.IsMatch(email, REGEX_EMAIL);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Email should not be null");
            }
        }
        public bool ValidateMobNo(string mobNo)
        {
            try
            {
                if (mobNo.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Mobile number should not be empty");
                }
                mobileNo = mobNo;
                return Regex.IsMatch(mobNo, REGEX_MOB_NO);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Mobile number should not be null");
            }
        }
        public bool ValidatePassword(string password)
        {
            try
            {
                if (password.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Password should not be empty");
                }
                passWord = password;
                return Regex.IsMatch(password, REGEX_PASSWORD);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Password should not be null");
            }
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
