using System;
using System.Collections.Generic;

namespace FractionApp
{
    class Program
    {
        static void Main (string[] args)
        {
            Fraction fraction = new Fraction(1, 2);
            Console.WriteLine(fraction);
            Fraction secondFraction = new Fraction(4, 4);
            Fraction thirdFraction = new Fraction(1, 4);

            Console.WriteLine("The result of 5/6 * 4/9 = " + fraction * secondFraction);
            Console.WriteLine("Parse "+ Fraction.Parse("4/8"));

            Console.WriteLine(fraction.DecimalValue);

            fraction.CompareTo(secondFraction);
            List<Fraction> fractionList = new List<Fraction>();
            fractionList.AddRange(new Fraction[] {fraction, secondFraction, thirdFraction });

            foreach (Fraction item in fractionList)
                Console.Write(item+" ");

            fractionList.Sort();
            Console.WriteLine();

            foreach (Fraction item in fractionList)
                Console.Write(item+ " ");

            
            Fraction testFraction = new Fraction(3, 6);
            Console.WriteLine("\nFraction before cancelation "+testFraction);
            testFraction.Cancel();
            Console.WriteLine("Fraction after cancelation "+testFraction);

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
