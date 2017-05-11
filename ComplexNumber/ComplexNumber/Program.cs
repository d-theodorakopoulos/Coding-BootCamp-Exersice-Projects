using System;

namespace ComplexNumberApp
{
    class Program
    {
        static void Main (string[] args)
        {
            ComplexNumber number = new ComplexNumber(4, -5);
            ComplexNumber other = new ComplexNumber(1, 2);

            Console.WriteLine(number + " "+ other);

            Console.WriteLine(number + other);
            Console.WriteLine(number.Add(other));
            Console.WriteLine(number.Multiply(other));

            Console.WriteLine("Give a complex number : ");
            string input = Console.ReadLine();

            try
            {
                Console.WriteLine(ComplexNumber.Parse(input));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("press a key to continue...");
            Console.ReadKey();
        }
    }
}
