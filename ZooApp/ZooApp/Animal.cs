using System;

namespace ZooApp
{
    public enum Gender { Male, Female}

    public abstract class Animal : IComparable<Animal>
    {
        private string _name;

        public Gender AnimalGender { get; private set; }
        public byte Age { get; private set; }
        public string Name
        {
            get { return _name; }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                    throw new Exception("Wrong name!");
            }
        }

        public Animal (byte age, string name, Gender gender)
        {
            AnimalGender = gender;
            Name = name;
            Age = age;
        }

        public virtual string ToString ()
        {
            return $"The {Name} is {Age} old and is {AnimalGender}";
        }

        public abstract string MakeSound ();

        public int CompareTo (Animal other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }
}
