using NullWorries.Infrastructure;

namespace NullWorries
{
    public static class F
    {
        public static None None => None.Value;

        public static Some<T> Some<T>(T value) => new(value);
    }
}
