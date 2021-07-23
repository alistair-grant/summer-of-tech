namespace Builders
{
    public class Part
    {
        internal Part(string partNumber, string description, decimal listPrice)
        {
            PartNumber = partNumber;
            Description = description;
            ListPrice = listPrice;
        }

        public string PartNumber { get; }

        public string Description { get; }

        public decimal ListPrice { get; }
    }
}
