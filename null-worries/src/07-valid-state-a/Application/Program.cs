using System.Linq;

namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            Book book = new(null);

            // will this work?
            var searchTerm = "the";
            var isMatch = book.Title.Contains(searchTerm);

            Author author = new();

            // will this work?
            var hasBooks = author.Books.Any();
        }
    }
}
