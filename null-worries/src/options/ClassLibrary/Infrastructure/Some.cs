using System;

namespace Options.Infrastructure
{
    public struct Some<T>
    {
        internal Some(T value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        internal T Value { get; }
    }
}
