using System;
namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetailsValidator v = new UserDetailsValidator();
            Console.WriteLine("User Registration System");
            v.ValidateFirstName();
            v.ValidateLastName();
            v.ValidateEmail();
            v.Display();
        }
    }
}

