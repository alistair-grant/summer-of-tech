namespace NullWorries.Models
{
    public class Person
    {
        public Person(string givenName, string familyName)
        {
            GivenName = givenName;
            FamilyName = familyName;
        }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }
    }
}
