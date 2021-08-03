using NullWorries.Models;
using System;

namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            // born 01 April 3000
            Person a = new("Jane", "Citizen", DateTime.Parse("3000-04-01"));

            // choice to omit date of birth
            Person b = new("Jane", "Citizen", null);
        }
    }
}
