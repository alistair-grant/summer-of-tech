using System;

namespace Options.Infrastructure
{
    public struct Some<T>
    {
        internal Some(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        internal T Value { get; }
    }
}
