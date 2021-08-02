using System;

namespace NullWorries.Models
{
    public class Book
    {
        public Book(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public string Title { get; }
    }
}
