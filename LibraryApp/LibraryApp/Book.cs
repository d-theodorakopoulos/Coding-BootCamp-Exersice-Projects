using System;

namespace LibraryApp
{
    public class Book :IEquatable<Book>
    {
        private static int _lastISBN = 1;

        public string Name { get; private set; }
        public string Author { get; private set; }
        public int ISBN { get; private set; }

        public Book (string name, string author)
        {
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(author))
            {
                Name = name;
                Author = author;
                ISBN = _lastISBN++;
            }
            else
                throw new Exception("Wrong Arguments!");
        }

        public override string ToString ()
        {
            return $"Book: {Name} written by {Author}. ISBN {ISBN}";
        }

        public bool Equals (Book other)
        {
            if (this.Name == other.Name)
                return true;
            else
                return false;
        }
    }
}
