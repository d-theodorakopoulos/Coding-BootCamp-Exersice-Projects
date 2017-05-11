using System;

namespace CoffeeApp
{
    /*
     * A) A cafeteria serves coffee in three variations; Small size is 100 ml, normal is 150 ml and double is 300 ml. 
     * Implement the class Coffee. Use Enumerations for the different sizes. Create a sample coffee and print its characteristic.
     * For example, Normal coffee is 150 ml. 
     * B) Create a class Order which implements a method CalculateCost which takes as input an array of coffee order items and returns 
     * the total price of the order. The price of the coffee is based on its size. Small costs 0.50 euro, normal 1.5 and double 2.50
     * */
    class Program
    {
        static void Main (string[] args)
        {
            Coffee normalCoffee = new Coffee(CoffeeVariation.Normal);
            Coffee doubleCoffee = new Coffee(CoffeeVariation.Double);
            Coffee smallCoffee = new Coffee(CoffeeVariation.Small);

            Console.WriteLine(normalCoffee + " has " + normalCoffee.Price);

            Order myOrder = new Order();
            myOrder.AddCoffee(doubleCoffee);
            myOrder.AddCoffee(smallCoffee);

            myOrder.RandomOrder(4);

            Console.WriteLine(myOrder.ShowDetailedBill());
            Console.WriteLine(myOrder.FinalPrice+ "euro");


            Console.WriteLine("press key to continue...");
            Console.ReadKey();
        }
    }
}
