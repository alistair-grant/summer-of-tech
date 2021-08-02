using System;
using System.Collections.Generic;
using System.Linq;

namespace NullWorries
{
    public class Author
    {
        public Author()
        {
            Books = Enumerable.Empty<Book>();
        }

        public Author(IEnumerable<Book> books)
        {
            Books = books ?? throw new ArgumentNullException(nameof(books));
        }

        public IEnumerable<Book> Books { get; }
    }
}
