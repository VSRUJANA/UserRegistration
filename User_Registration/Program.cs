using System;
namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetailsValidator v = new UserDetailsValidator();
            Console.WriteLine("User Registration System");
            Console.WriteLine("Enter first name");
            string fName = Console.ReadLine();
            v.ValidateFirstName(fName);
            Console.WriteLine("Enter last name");
            string lName = Console.ReadLine();
            v.ValidateLastName(lName);
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            v.ValidateEmail(email);
            Console.WriteLine("Enter mobile number");
            string mobNo = Console.ReadLine();
            v.ValidateMobNo(mobNo);
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            v.ValidatePassword(password);
            v.Display();
        }
    }
}

