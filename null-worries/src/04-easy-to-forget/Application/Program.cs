using System.Text.RegularExpressions;

namespace NullWorries
{
    internal class Program
    {
        private static void Main()
        {
            var obj = ObjectHelper.GetObject();

            // will this work?
            var text = obj.ToString();

            // if it does, will this work?
            var n = text.Length;

            // how about this?
            Regex pattern = new("\\d{4,}");
            var isMatch = pattern.IsMatch(text);
        }
    }
}
