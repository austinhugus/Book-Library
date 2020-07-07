using System;
using console_library.Models;

namespace concole_Library {

    public class App {
        public Book Book { get; set; }
        public bool Running { get; private set; }
        public void Run () {
            Console.Clear ();
            Library = new Library ("Harry Potter", "JK Rowling");
            Console.WriteLine ();
        }

        internal void Run () {

        }
    }
}