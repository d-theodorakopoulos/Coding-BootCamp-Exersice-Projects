using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class User : IEquatable<User>
    {
        public string Name { get;private set; }

        public User (string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Name = name;
        }

        public bool Equals (User other)
        {
            if (this.Name == other.Name)
                return true;
            else
                return false;
        }
    }
}
