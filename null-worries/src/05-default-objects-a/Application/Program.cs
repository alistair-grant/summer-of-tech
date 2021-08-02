using NullWorries.Models;

namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            var person = Person.GetPerson("Jane");

            // will this work?
            var text = person.ToString();
        }
    }
}
