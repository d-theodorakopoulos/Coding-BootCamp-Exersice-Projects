using System;
using System.Collections.Generic;

namespace LibraryApp
{
    class Program
    {
        static void Main (string[] args)
        {
            User nikos = new User("nikos");
            User giorgos = new User("giorgos");
            User alex = new User("Alex");
            User jina = new User("Jina");
            User savvas = new User("Savvas");
            User gio = new User("Gio");

            Book tango = new Book("Tango", "TangoFix");
            Book zoo   = new Book("Zoo", "Lion");
            Book beer = new Book("Beer", "Heineken");
            Book lordOfTheRings = new Book("Lord of the Rings", "J.R Tolkin");
            Book idiana = new Book("Idiana Jones", "Lukas");
            Book cod = new Book("Call of Duty", "Activision");

            Library nationalLibrary = new Library("National Library");

            Librarian nikosLibrarian = new Librarian("Nikos the Great", nationalLibrary);

            nationalLibrary.RegisterUser(nikos);

            nationalLibrary.AddBooks(new List<Book>() { tango, zoo, beer, lordOfTheRings, cod });
            nationalLibrary.RegisterUsers(new List<User>() { nikos, giorgos, alex, jina, savvas });

            AskForBook(nikos, nikosLibrarian, zoo);

            Console.ReadKey();
        }

        static void AskForBook(User user, Librarian librarian, Book book)
        {
            Console.WriteLine(librarian.IsBookExists(user, book));
        }
    }
}
