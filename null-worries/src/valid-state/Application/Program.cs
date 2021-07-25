using System.Linq;
using ValidState;

Book book = new(null);
//Book book = new("Screens");

// exception: ?
var searchTerm = "the";
var isMatch = book.Title.Contains(searchTerm);

// exception: ?
Author author = new();
var hasBooks = author.Books.Any();
