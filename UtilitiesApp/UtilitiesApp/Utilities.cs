using System;
using System.Collections.Generic;
using ComplexNumber;

namespace UtilitiesApp
{
    public static class Utilities
    {
        public static void SwapNumbers(ref int first,ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        public static void SwapItems<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

        public static List<int> LongestSubsequenceInteger(List<int> list)
        {
            return LongestSubsequence<int>(list);
        }

        public static List<T> LongestSubsequence<T>(List<T> list)
        {
            List<T> subsequence = new List<T>();
            int currentLength = 0;
            int maxLength = 0;
            T maxValue = default(T);

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j < list.Count; j++)
                {
                    if (!list[i].Equals(list[j]))
                    {
                        if (currentLength > maxLength)
                        {
                            maxValue = list[i];
                            maxLength = currentLength;
                        }
                        currentLength = 0;
                        break;
                    }

                    currentLength++;
                }
            }

            for (int i = 0; i < maxLength; i++)
                subsequence.Add(maxValue);

            return subsequence;
        }

        public static List<T> Subsubsquence<T>(this List<T> list)
        {
            List<T> subsequence = new List<T>();
            int currentLength = 0;
            int maxLength = 0;
            T maxValue = default(T);

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j < list.Count; j++)
                {
                    if (!list[i].Equals(list[j]))
                    {
                        if (currentLength > maxLength)
                        {
                            maxValue = list[i];
                            maxLength = currentLength;
                        }
                        currentLength = 0;
                        break;
                    }

                    currentLength++;
                }
            }

            for (int i = 0; i < maxLength; i++)
                subsequence.Add(maxValue);

            return subsequence;
        }

            
        public static QuandicResult QuadraticEquation (double a, double b, double c)
        {
            double diakrinousa = Math.Pow(b, 2) - (4 * a *c);

            Console.WriteLine("Diakrinousa ="+ diakrinousa);

            if (diakrinousa >= 0)
            {
                results[0] = (-b + Math.Sqrt(diakrinousa)) / 2 * a;
                results[1] = (-b - Math.Sqrt(diakrinousa)) / 2 * a;
                return results;
            }
            else
            {
                
            }
        }

    }

    public class QuandicResult
    {
        public double[] RealResults { get; private set; }
        public ComplexNumber.ComplexNumber[] ComplexResults { get; private set; }

        public QuandicResult ()
        {
            RealResults = new double[2];
            ComplexResults = new ComplexNumber.ComplexNumber[2];

            ComplexResults[0] = new ComplexNumber.ComplexNumber();
            ComplexResults[1] = new ComplexNumber.ComplexNumber();
        }
    }
}
