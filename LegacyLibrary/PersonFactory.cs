using System;

namespace LegacyLibrary
{
    public static class PersonFactory
    {
        public static Person CreatePerson(string firstName, string lastName, int age)
        {
            if (!string.IsNullOrWhiteSpace(firstName)
                && !string.IsNullOrWhiteSpace(lastName)
                && age >= 0)
            {
                return new Person { FirstName = firstName, LastName = lastName, Age = age };
            }
            return null;
        }
    }
}
