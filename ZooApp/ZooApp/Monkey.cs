using System;
using System.Collections.Generic;

namespace ZooApp
{
    public enum MonkeyFurColor {Black, Brown, Orange, White }
    public enum MonkeyBreed { Baboon, Capuchin, BlueMonkey, JapaneseMacaque }

    public class Monkey : Animal
    {
        private bool _wasCapturedIntoWild = false;
        private List<MonkeyFurColor> _furColors;

        public bool WasCapturedIntoWild { get { return _wasCapturedIntoWild; } }
        public MonkeyBreed Breed { get; private set; }
        public string FurColors
        {
            get
            {
                string furColors = "";
                foreach (MonkeyFurColor item in _furColors)
                {
                    furColors += item.ToString()+" ";
                }
                return furColors;
            }
        }


        public Monkey (byte age, string name, Gender gender, List<MonkeyFurColor> furColors, MonkeyBreed breed, bool wasCapturedIntoWild) : base(age, name, gender)
        {
            Breed = breed;
            _wasCapturedIntoWild = wasCapturedIntoWild;

            if (furColors == null || furColors.Count < 1)
            {
                throw new Exception("Wrong Fur Colors");
            }
            else
                _furColors = new List<MonkeyFurColor>(furColors);
        }

        public override string ToString ()
        {

            return base.ToString() + $" and is {Breed} Monkey with {FurColors}fur and {WasCapturedIntoWild}";
        }

        public override string MakeSound ()
        {
            return "Wouhhh Wouhhh";
        }
    }
}
