using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidState
{
    public class Author
    {
        public Author()
        {
            // use default initializers

            //Books = Enumerable.Empty<Book>();
        }

        public Author(IEnumerable<Book> books)
        {
            Books = books ?? throw new ArgumentNullException(nameof(books));
        }

        public IEnumerable<Book> Books { get; }
    }
}
