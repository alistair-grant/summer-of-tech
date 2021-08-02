using System;

namespace NullWorries
{
    public class Person
    {
        public static readonly Person Unknown = new(string.Empty, string.Empty, null);

        public Person(string givenName, string familyName, DateTime? dateOfBirth)
        {
            GivenName = givenName;
            FamilyName = familyName;

            if (dateOfBirth != null && dateOfBirth.Value < DateTime.Now)
            {
                DateOfBirth = dateOfBirth;
            }
        }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public static Person GetPerson(string name)
        {
            // if not found...
            return Unknown;
        }
    }
}
