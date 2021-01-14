using LegacyLibrary;
using System;

namespace NrtEnabledProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInfo = GetUserInfo();

            Console.WriteLine("Your name is {0} {1} and you are {2} years old",
                userInfo.FirstName, userInfo.LastName, userInfo.Age);
        }

        private static Person GetUserInfo()
        {
            Console.WriteLine("Please enter your first name:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            var lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            int.TryParse(Console.ReadLine(), out var age);

            var person = PersonFactory.CreatePerson(firstName, lastName, age);
            return person;
        }
    }
}
