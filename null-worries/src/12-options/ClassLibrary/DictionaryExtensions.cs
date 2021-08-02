using System.Collections.Generic;

using static NullWorries.F;

namespace NullWorries
{
    public static class DictionaryExtensions
    {
        public static Option<TValue> GetValue<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key) =>
            source.TryGetValue(key, out var value) ? Some(value) : None;
    }
}
