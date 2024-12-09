using System;

namespace TechFielders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            string firstName = "Dean";
            string lastName = "Clarke";
            DateOnly dob = new DateOnly(1990, 11, 19);
            string email = "dclarke@twilio.com";
            string phone = "+61409260337";
            UserType type = UserType.ORG_USER;

            User user = new User(id, firstName, lastName, dob, email, phone, type);
            Console.WriteLine(user.DateOfBirth);
        }
    }
}
