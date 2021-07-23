using System.Linq;
using ValidState;

// run-time error
Book a = new(null);

Book b = new("Screens");

Author author = new();
var hasBooks = author.Books.Any();
