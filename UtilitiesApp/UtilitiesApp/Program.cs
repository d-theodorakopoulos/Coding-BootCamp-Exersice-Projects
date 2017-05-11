using System;
using System.Collections.Generic;
using CoffeeApp;
using FractionApp;

namespace UtilitiesApp
{
    class Program
    {
        static void Main (string[] args)
        {
            //float x = 5.6f;
            //float y = 3.4f;

            //Coffee oneCoffee = new Coffee(CoffeeVariation.Double);
            //Coffee secondCoffee = new Coffee(CoffeeVariation.Small);

            //ConsoleKey myKey = ConsoleKey.A;
            //ConsoleKey anotherKey = ConsoleKey.B;

            //Console.WriteLine("First object "+ oneCoffee + " second object " + secondCoffee);
            //Utilities<Coffee>.SwapItems(ref oneCoffee, ref secondCoffee);
            //Console.WriteLine("First object " + oneCoffee + " second object " + secondCoffee);

            /*
             * Fraction oneForTwo = new Fraction(1, 2);
            Fraction threeForFour = new Fraction(3, 4);
            Fraction sixForTwo = new Fraction(6, 2);

            List<int> list = new List<int>() { 1,1,1,1, 2, 3, 3, 3, 3, 3, 4, 4, 4 };
            List<Fraction> fractions = new List<Fraction>() {oneForTwo, oneForTwo , oneForTwo , sixForTwo , sixForTwo, sixForTwo, sixForTwo, sixForTwo, sixForTwo, threeForFour };

            foreach (var item in list)
                Console.Write(item+ " ");

            Console.WriteLine();

            foreach (var item in Utilities.LongestSubsequenceInteger(list))
                Console.Write(item+" ");
            Console.WriteLine();
            foreach (var item in fractions)
                Console.Write(item + " ");
            Console.WriteLine();
            foreach (var item in Utilities.LongestSubsequence<Fraction>(fractions))
                Console.Write(item + " ");*/

            double[] results = Utilities.QuadraticEquation(1, -2, 1);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPress a key to continue...");
            Console.ReadKey();
        }
    }
}
