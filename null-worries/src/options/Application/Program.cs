using Options;
using System;
using System.Collections.Generic;

using static System.Console;

// implicit conversion
Option<int> a = new Random().Next();
WriteLine(
    a.Match(
        none: () => "None",
        some: value => $"Some({value})"));

// dictionary extension
var key = Guid.NewGuid().ToString();
Dictionary<string, string> dictionary = new() { { key, "Hello world!" } };
WriteLine(
    dictionary.GetValue(key).Match(
        none: () => "Key not found",
        some: value => $"Value is \"{value}\"."));
