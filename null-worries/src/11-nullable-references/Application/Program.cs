namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            // valid: can be null
            object? a = null;

            // CS8600: Converting null literal or possible null value to non-nullable type.
            object b = null;

            var obj = new object();
            var text = obj.ToString();

            // CS8602 Dereference of a possibly null reference
            var n = text.Length;

            if (text != null)
            {
                var m = text.Length;
            }
        }
    }
}
