using System;

namespace EasyToForget
{
    public static class Helper
    {
        private static readonly Random _random = new Random();

        public static object GetObject() =>
            _random.Next() % 2 == 0 ? new() : null;
    }
}
