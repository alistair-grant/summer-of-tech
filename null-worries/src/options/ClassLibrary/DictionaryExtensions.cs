using System.Collections.Generic;

using static Options.F;

namespace Options
{
    public static class DictionaryExtensions
    {
        public static Option<TValue> GetValue<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key) =>
            source.TryGetValue(key, out var value) ? Some(value) : None;
    }
}
