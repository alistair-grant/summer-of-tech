using System;

using static Options.F;

namespace Options
{
    public struct Option<T>
    {
        private readonly bool _hasValue;
        private readonly T _value;

        private Option(T value)
        {
            _hasValue = true;
            _value = value;
        }

        public static implicit operator Option<T>(Infrastructure.None _) =>
            new();

        public static implicit operator Option<T>(Infrastructure.Some<T> some) =>
            new(some.Value);

        public static implicit operator Option<T>(T value) =>
            value == null ? None : Some(value);

        public TResult Match<TResult>(Func<TResult> none, Func<T, TResult> some) =>
            _hasValue ? some(_value) : none();
    }
}
