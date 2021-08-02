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
        }
    }
}
