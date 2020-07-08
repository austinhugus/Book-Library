using System;
using console_library.Models;

namespace concole_Library {

    public class App {
        public Book Book { get; set; }
        public bool Running { get; private set; }
        public void Run () {
            Console.Clear ();
            Library = new Library ("First Street", "Austin Library");

            Console.WriteLine ();
        }

        internal void Run () {

        }
    }
}