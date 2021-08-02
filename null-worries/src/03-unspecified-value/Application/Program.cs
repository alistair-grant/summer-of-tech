using NullWorries.Models;
using System;

namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            // valid date of birth
            Person a = new("Jane", "Citizen", DateTime.Parse("2000-12-25"));

            // born 01 April 3000
            Person b = new("Jane", "Citizen", DateTime.Parse("3000-04-01"));

            // choice to omit date of birth
            Person c = new("Jane", "Citizen", null);
        }
    }
}
