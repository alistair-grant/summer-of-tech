using System;

namespace NullWorries.Helpers
{
    public static class ObjectHelper
    {
        private static readonly Random _random = new();

        public static object? GetObject() =>
            _random.Next() % 2 == 0 ? new() : null;
    }
}
