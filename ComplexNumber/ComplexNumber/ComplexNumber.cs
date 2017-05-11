using System;

namespace ComplexNumberApp
{
    /*
     * Model the complex number as a class in C#. create constructors for different input parameters. 
     * Implement common operations such as addition and subtraction as methods of the class and as overloaded operators. 
     * Finally, override ToString() method for informative output.
     * X - Yi
     */

    public class ComplexNumber
    {
        public const float IPower2 = -1f;
        public float RealPart { get; set; }
        public float ImaginaryPart { get; set; }
        
        public ComplexNumber ComplexConjugate
        {
            get { return new ComplexNumber(this.RealPart, -1f * this.ImaginaryPart); }
        }

        public ComplexNumber ()
        {
            RealPart = 0;
            ImaginaryPart = 0;
        }

        public ComplexNumber (float real, float imaginary)
        {
            RealPart = real;
            ImaginaryPart = imaginary;
        }

        public ComplexNumber Add(ComplexNumber otherNumber)
        {
            ComplexNumber result = new ComplexNumber(this.RealPart + otherNumber.RealPart, this.ImaginaryPart + otherNumber.ImaginaryPart);
            return result;
        }

        public ComplexNumber Subtract(ComplexNumber otherNumber)
        {
            return new ComplexNumber(this.RealPart - otherNumber.RealPart, this.ImaginaryPart - otherNumber.ImaginaryPart);
        }

        public ComplexNumber Multiply(ComplexNumber otherNumber)
        {
            float realPart = this.RealPart * otherNumber.RealPart - this.ImaginaryPart * otherNumber.ImaginaryPart;
            float imaginaryPart = this.ImaginaryPart * otherNumber.RealPart + this.RealPart * otherNumber.ImaginaryPart;

            return new ComplexNumber(realPart, imaginaryPart);
        }


        // Declare which operator to overload (+), the types that can be added (two Complex objects), and the return type (Complex)
        public static ComplexNumber operator +(ComplexNumber number, ComplexNumber otherNumber)
        {
            return new ComplexNumber(number.RealPart + otherNumber.RealPart, number.ImaginaryPart + otherNumber.ImaginaryPart);
        }

        public static bool operator ==(ComplexNumber number, ComplexNumber otherNumber)
        {
            if (number.RealPart == otherNumber.RealPart && number.ImaginaryPart == otherNumber.ImaginaryPart)
                return true;
            else
                return false;
        }

        public static bool operator != (ComplexNumber number, ComplexNumber otherNumber)
        {
            if (number.RealPart != otherNumber.RealPart || number.ImaginaryPart != otherNumber.ImaginaryPart)
                return false;
            else
                return true;
        }

        public override string ToString ()
        {
            if(this.ImaginaryPart > 0)
                return string.Format("{0}+{1}i", RealPart, ImaginaryPart);
            return string.Format("{0}{1}i", RealPart, ImaginaryPart);
        }

        public bool Equals (ComplexNumber otherNumber)
        {
            return this.RealPart == otherNumber.RealPart && this.ImaginaryPart == otherNumber.ImaginaryPart ? true : false;
        }

        public static ComplexNumber Parse(string input)
        {
            string real = "";
            string imaginary = "";

            if (input.Contains("+"))
            {
                real = input.Split('+')[0];
                imaginary = input.Split('+')[1];
                imaginary = imaginary.Remove(1);

                return new ComplexNumber(float.Parse(real), float.Parse(imaginary));
            }
            else if (input.Contains("-"))
            {
                real = input.Split('-')[0];
                imaginary = input.Split('-')[1];
                imaginary = imaginary.Remove(1);

                return new ComplexNumber(float.Parse(real), -float.Parse(imaginary));
            }
            else
                throw new Exception("wrong syntax of a complex number!");
        }
    }
}
