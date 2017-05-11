using System;

namespace VideoTest
{
    public class Color
    {
        public byte Red { get; private set; }
        public byte Green { get; private set; }
        public byte Blue { get; private set; }

        public const byte Min = 0;
        public const byte Max = 255;

        public Color()
        {
            Red = 255;
            Green = 255;
            Blue = 255;
        }

        public Color(byte r, byte g, byte b)
        {
            SetValues(r, g, b);
        }

        private bool SetValues (byte r, byte g, byte b)
        {
            if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
            {
                Red = r;
                Green = g;
                Blue = b;
                return true;
            }
            else
                return false;
        }

        public bool SetValue(string component, byte value)
        {
            switch (component.ToLower())
            {
                case "red":
                    Red = value;
                    return true;
                case "green":
                    Green = value;
                    return true;
                case "blue":
                    Blue = value;
                    return true;
                default:
                    return false;
            }
        }

        public override string ToString()
        {
            return String.Format("R {0} G {1} B {2} ", Red, Green, Blue);
        }
    }
}
