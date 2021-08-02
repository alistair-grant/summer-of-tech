using System;
using System.Collections.Generic;

namespace NullWorries
{
    public class Author
    {
        public Author()
        {
            // use default initializers
        }

        public Author(IEnumerable<Book> books)
        {
            Books = books ?? throw new ArgumentNullException(nameof(books));
        }

        public IEnumerable<Book> Books { get; }
    }
}
