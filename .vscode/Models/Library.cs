using System;
using System.Collections.Generic;

namespace console_library.Models {
    public class Library {

        string _Name;
        public string Name { get { return _Name; } set { _Name = value; } }

        public string Location { get; set; }

        public List<Book> Books { get; set; } = new List<Book> ();

        public void ViewBooks () {
            Console.WriteLine ("Books In Stock : /n");
            for (int i = 0; i < Books.Count; i++) {
                Book book = Books[i];
                if (book.Available) {
                    Console.WriteLine ($"{i + 1}. {book}");
                }
            }
        }
        public void ViewBooks (bool available) {
            System.Console.WriteLine ("Book Stock: ");
            ConsoleColor forecolor = Console.ForegroundColor;
            for (int i = 0; i < Books.Count; i++) {
                Book book = Books[i];
                if (book.Available == available) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine ($"{i + 1}. {book.Title} by {book.Author} x {book.Available}");
                } else {
                    Console.ForegroundColor = forecolor;
                    System.Console.WriteLine ($"{i + 1}. {book.Title} by {book.Author} x {book.Available}");
                }
            }
            Console.ForegroundColor = forecolor;
        }

        public Library (string location, string name) {
            Location = location;
            Name = name;

            Books.Add (new Book ("The Raven", "Edgar Allen Poe", 50));
            Books.Add (new Book ("Lord of the Rings", "Tolkien", 20));
            Books.Add (new Book ("C# for dummies", "Mark Ohnsman", 100));
        }
        public Library () {
            Location = "default";
            Name = "default";
        }

        internal Book checkBookAvailability (string selection) {
            int bookIndex;
            bool valid = Int32.TryParse (selection, out bookIndex);
            if (!valid || bookIndex < 1 || bookIndex > Books.Count) {
                return null;
            }
            return Books[bookIndex - 1];
        }
    }
}