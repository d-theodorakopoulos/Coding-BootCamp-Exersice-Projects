using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class Library
    {
        public string Name { get; private set; }
        public List<Book> Books { get; private set; }
        public List<User> AuthorizedUsers { get; private set; }

        public Library (string name)
        {
            Books = new List<Book>();
            AuthorizedUsers = new List<User>();

            if (!string.IsNullOrWhiteSpace(name))
                Name = name;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddBooks(IEnumerable<Book> books)
        {
            Books.AddRange(books);
        }

        public void RegisterUser(User user)
        {
            AuthorizedUsers.Add(user);
        }

        public void RegisterUsers(IEnumerable<User> users)
        {
            AuthorizedUsers.AddRange(users);
        }

        public bool IsUserAuthorized(User user)
        {
            return AuthorizedUsers.Contains(user);
        }

        public bool IsBookExistsInLibrary(Book book)
        {
            return Books.Contains(book);
        }
    }
}
