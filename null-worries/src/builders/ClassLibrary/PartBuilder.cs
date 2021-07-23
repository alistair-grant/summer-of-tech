using System;

namespace Builders
{
    public class PartBuilder : IUninitialized, IPartNumberInitialized, IDescriptionInitialized, IListPriceInitialized
    {
        private string _partNumber;
        private string _description;
        private decimal _listPrice;

        public PartBuilder()
        {
            _description = string.Empty;
        }

        public IPartNumberInitialized PartNumber(string partNumber)
        {
            // Should we validate the part number format?
            if (string.IsNullOrWhiteSpace(partNumber))
            {
                throw new ArgumentException("Part number cannot be null, empty or white-space.", nameof(partNumber));
            }

            _partNumber = partNumber;

            return this;
        }

        IDescriptionInitialized IPartNumberInitialized.Description(string description)
        {
            // Should we allow an empty string?
            // What about leading and/or trailing white-space?
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Description cannot be null, empty or white-space.", nameof(description));
            }

            _description = description;

            return this;
        }

        IListPriceInitialized IDescriptionInitialized.ListPrice(decimal listPrice)
        {
            if (listPrice < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(listPrice), "List price cannot be negative.");
            }

            _listPrice = listPrice;

            return this;
        }

        Part IListPriceInitialized.Build() =>
            new(_partNumber, _description, _listPrice);
    }
}
