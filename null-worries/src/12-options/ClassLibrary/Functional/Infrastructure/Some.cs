using System;

namespace NullWorries.Functional.Infrastructure
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
