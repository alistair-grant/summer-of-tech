using System.Linq;

namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            Author author = new();

            // will this work?
            var hasBooks = author.Books.Any();
        }
    }
}
