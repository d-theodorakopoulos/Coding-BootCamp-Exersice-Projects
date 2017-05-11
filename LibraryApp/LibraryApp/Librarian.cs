using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class Librarian
    {
        private Library _workingLibrary;

        public User LibrarianUser { get; private set; }

        public Librarian (string name, Library library)
        {
            if (string.IsNullOrWhiteSpace(name) || library == null)
                throw new Exception("Wrong arguments!");

            _workingLibrary = library;
            LibrarianUser = new User(name);
        }

        public bool IsBookExists(User askingUser, Book askingBook)
        {
            if (_workingLibrary.IsUserAuthorized(askingUser) && _workingLibrary.IsBookExistsInLibrary(askingBook))
                return true;

            return false;
        }
    }
}
