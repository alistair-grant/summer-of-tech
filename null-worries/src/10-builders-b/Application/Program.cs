namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            // compiler error
            Part a = new("1234-abcd", "Sample part", 12.95m);

            // has description
            var b = new PartBuilder()
                .PartNumber("1234-abcd")
                .Description("Sample part")
                .ListPrice(12.95m)
                .Build();

            // no description
            var c = new PartBuilder()
                .PartNumber("1234-abcd")
                .ListPrice(12.95m)
                .Build();

            // compiler error
            var d = new PartBuilder()
                .PartNumber("1234-abcd")
                .Build();

            // run-time error
            var e = new PartBuilder()
                .PartNumber(null)
                .ListPrice(12.95m)
                .Build();
        }
    }
}
