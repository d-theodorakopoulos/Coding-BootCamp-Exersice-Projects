using System;

namespace FractionApp
{
    public class Fraction : IComparable, IEquatable<Fraction>
    {
        private int _denominator;

        public int Numerator { get; private set; }
        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                if (value > 0)
                    _denominator = value;
                else
                    throw new Exception("Denominator cant be zero!");
            }
        }
        public decimal DecimalValue { get { return (decimal)Numerator / (decimal)Denominator; } }

        public Fraction (int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator *(Fraction fraction, Fraction otherFraction)
        {
            return new Fraction(fraction.Numerator * otherFraction.Numerator, fraction.Denominator * otherFraction.Denominator);
        }

        public static Fraction Parse(string fraction)
        {
            if (fraction.Split('/').Length != 2)
                throw new Exception("Wrong Fraction! Fraction must be like '1/2' ");

            return new Fraction(Int32.Parse(fraction.Split('/')[0]), Int32.Parse(fraction.Split('/')[1]));
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }

        public int CompareTo (object obj)
        {
            if (obj.GetType() != new Fraction(1, 1).GetType() || obj == null)
                throw new Exception("Wrong type argument!");

            Fraction otherFraction = (Fraction)obj;

            return this.DecimalValue.CompareTo(otherFraction.DecimalValue);
        }

        public bool Cancel()
        {
            int min = (this.Numerator < this.Denominator) ? this.Numerator : this.Denominator;

            for (int i = min; i > 0; i--)
            {
                if (this.Numerator % i == 0 && this.Denominator % i == 0)
                {
                    this.Numerator /= i;
                    this.Denominator /= i;
                    return false;
                }
            }
            return true;
        }

        public static bool Cancel(ref Fraction fraction)
        {
            int min = (fraction.Numerator < fraction.Denominator) ? fraction.Numerator : fraction.Denominator;

            for (int i = min; i > 0; i--)
            {
                if (fraction.Numerator % i == 0 && fraction.Denominator % i == 0)
                {
                    fraction = new Fraction(fraction.Numerator / i, fraction.Denominator / i);
                    return true;
                }
            }

            return false;
        }

        public bool Equals (Fraction other)
        {
            return this.Numerator.Equals(other.Numerator) && this.Denominator.Equals(other.Denominator);
        }
    }
}
