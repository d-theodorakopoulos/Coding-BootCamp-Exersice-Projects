using System;
using System.Collections.Generic;

namespace ZooApp
{
    public enum LionBreed { Asiatic, Barbary, WestAfrican, Congo }
    public enum LionFurColor { White, Orange, Grey, Brown }

    public class Lion : Animal
    {
        private bool _wasCapturedIntoWild = false;
        private List<LionFurColor> _furColors;

        public bool WasCapturedIntoWild { get { return _wasCapturedIntoWild; } }
        public LionBreed Breed { get; private set; }
        public string FurColors
        {
            get
            {
                string furColors = "";
                foreach (LionFurColor item in _furColors)
                {
                    furColors += item.ToString()+" ";
                }
                return furColors;
            }
        }


        public Lion (byte age, string name, Gender gender, List<LionFurColor> furColors, LionBreed breed, bool wasCapturedIntoWild) : base(age, name, gender)
        {
            Breed = breed;
            _wasCapturedIntoWild = wasCapturedIntoWild;

            if (furColors == null || furColors.Count < 1)
            {
                throw new Exception("Wrong Fur Colors");
            }
            else
                _furColors = new List<LionFurColor>(furColors);
        }

        public override string ToString ()
        {

            return base.ToString() + $" and is {Breed} lion with {FurColors}fur and {WasCapturedIntoWild}";
        }

        public override string MakeSound ()
        {
            return "Waaahhhhh";
        }
    }
}
