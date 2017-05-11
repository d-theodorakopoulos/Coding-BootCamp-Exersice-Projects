using System;
using System.Collections.Generic;

namespace ZooApp
{
    public class Zoo
    {
        private List<Animal> _zooAnimals;

        public string Name { get; private set; }
        public List<Animal> Animals { get { return _zooAnimals; } }

        public Zoo(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Name = name;
            else
                throw new Exception("Wrong zoo name!");

            _zooAnimals = new List<Animal>();
        }

        public bool AddAnimal(Animal animal)
        {
            if (!_zooAnimals.Contains(animal))
            {
                _zooAnimals.Add(animal);
                return true;
            }

            return false;
        }

        public void AddAnimals (List<Animal> animals)
        {
            _zooAnimals.AddRange(animals);
        }

        public string GetAllAnimals()
        {
            string allAnimals = "";

            foreach (Animal animal in _zooAnimals)
            {
                allAnimals += animal.ToString() + " sounds like " + animal.MakeSound()+ "\n";
            }

            return allAnimals;
        }

        public void SortAnimalsByAge()
        {
            _zooAnimals.Sort();
        }
    }
}
