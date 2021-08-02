using NullWorries.Functional;
using System;
using System.Collections.Generic;

namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            Option<int> a = new Random().Next();

            Console.WriteLine(
                a.Match(
                    none: () => "None",
                    some: value => $"Some({value})"));

            var key = Guid.NewGuid().ToString();
            Dictionary<string, string> dictionary = new() { { key, "Hello world!" } };

            Console. WriteLine(
                dictionary.GetValue(key).Match(
                    none: () => "Key not found",
                    some: value => $"Value is \"{value}\"."));
        }
    }
}
