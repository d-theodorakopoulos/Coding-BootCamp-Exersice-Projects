using System;
using System.Collections.Generic;

namespace ZooApp
{
    class Program
    {
        static void Main (string[] args)
        {
            Cat garidas = new Cat(2, "Garidas", Gender.Male, CatBreed.Ocicat, new List<CatFurColor>() { CatFurColor.Orange, CatFurColor.White }, true);
            Lion simba = new Lion(50, "Simba", Gender.Male, new List<LionFurColor>() { LionFurColor.Brown }, LionBreed.Asiatic ,false);
            Monkey kim = new Monkey(30, "Kim", Gender.Female, new List<MonkeyFurColor>() { MonkeyFurColor.Orange, MonkeyFurColor.White }, MonkeyBreed.Baboon, true);
            Cat nancy = new Cat(3, "Nancy", Gender.Female, CatBreed.Ocicat, new List<CatFurColor>() { CatFurColor.Grey, CatFurColor.Black }, true);
            Lion bagira = new Lion(6, "Bagira", Gender.Male, new List<LionFurColor>() { LionFurColor.Brown }, LionBreed.Asiatic, false);
            Monkey Baloo = new Monkey(1, "Baloo", Gender.Male, new List<MonkeyFurColor>() { MonkeyFurColor.Orange, MonkeyFurColor.White }, MonkeyBreed.Baboon, true);

            Zoo myZoo = new Zoo("Zootopia");

            myZoo.AddAnimals(new List<Animal> { garidas, simba, kim, nancy, bagira , Baloo });

            Console.WriteLine(myZoo.GetAllAnimals());

            myZoo.SortAnimalsByAge();

            Console.WriteLine(myZoo.GetAllAnimals());
            Console.ReadKey();
        }
    }
}
