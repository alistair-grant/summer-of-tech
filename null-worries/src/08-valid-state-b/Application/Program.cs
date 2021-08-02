namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            // will this work?
            Book a = new(null);

            // how about this?
            Book b = new("Screens");
        }
    }
}
