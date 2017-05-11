using System;
using System.Collections.Generic;

namespace ZooApp
{
    public enum CatBreed { ScottishFold, Balinese, Persian, Ocicat}
    public enum CatFurColor { White, Black, Orange, Grey, Brown}

    public class Cat : Animal
    {
        private bool _isCatCaptured = false;
        private List<CatFurColor> _furColors;

        public CatBreed Breed { get; private set; }
        public string FurColors
        {
            get
            {
                string allColors = "";
                foreach (CatFurColor color in _furColors)
                {
                    allColors += color.ToString() + " ";
                }

                return allColors;
            }
        }
        public bool isCatCaptured { get { return _isCatCaptured; } }

        public Cat (byte age, string name, Gender catGender, CatBreed breed, List<CatFurColor> furColors, bool isCatCaptured) : base(age,name,catGender)
        {
            Breed = breed;
            _isCatCaptured = isCatCaptured;

            if (furColors == null || furColors.Count < 1)
            {
                throw new Exception("Wrong Fur Colors");
            }
            else
                _furColors = new List<CatFurColor>(furColors);
        }

        public override string ToString ()
        {

            return base.ToString() + $" and is {Breed} cat with {FurColors}fur and {isCatCaptured}";
        }

        public override string MakeSound ()
        {
            return "Meowww!";
        }
    }
}
