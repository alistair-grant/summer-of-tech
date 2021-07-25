using System.Text.RegularExpressions;

using static EasyToForget.Helper;

var obj = GetObject();
var text = obj.ToString();

var n = text.Length;

Regex pattern = new("^\\d{4,}$");
var isMatch = pattern.IsMatch(text);
