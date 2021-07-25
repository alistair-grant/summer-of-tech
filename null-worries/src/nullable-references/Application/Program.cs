// valid: can be null
object? a = null;

// invalid: cannot be null
object b = null;

var obj = new object();
var text = obj.ToString();

// CS8602 Dereference of a possibly null reference
var n = text.Length;

if (text != null)
{
    var m = text.Length;
}
