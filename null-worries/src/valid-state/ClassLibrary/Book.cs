using System;

namespace ValidState
{
    public class /*struct*/ Book
    {
        public Book(string title)
        {
            Title = title;

            //Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public string Title { get; }
    }
}
