using System;

namespace ValidState
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
