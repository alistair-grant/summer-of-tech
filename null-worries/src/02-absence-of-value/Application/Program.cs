namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            // Jane Citizen
            Person a = new("Jane", "Citizen");

            // unknown value: John ?
            Person b = new("John", null);

            // unnecessary value: Lorde
            Person c = new("Lorde", null);
        }
    }
}
