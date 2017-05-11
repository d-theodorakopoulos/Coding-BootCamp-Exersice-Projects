using System.Collections.Generic;

namespace CoffeeApp
{
    public class Order
    {
        private readonly List<Coffee> _order;
        private float _finalPrice;

        public float FinalPrice
        {
            get
            {
                CalculateFinalPrice();
                return _finalPrice;
            }
            private set
            {
                _finalPrice += value;
            }
            
        }

        public Order()
        {
            _order = new List<Coffee>();
            _finalPrice = 0f;
        }

        public bool AddCoffee (Coffee coffee)
        {
            if (coffee != null)
            {
                _order.Add(coffee);
                return true;
            }

            return false;
        }

        private float CalculateFinalPrice ()
        {
            foreach (Coffee product in _order)
            {
                FinalPrice = product.Price;
            }

            return _finalPrice;
        }

        public void RandomOrder(int amountOfCoffees)
        {
            for (int i = 0; i < amountOfCoffees; i++)
            {
                _order.Add(new Coffee());
            }
        }

        public string ShowDetailedBill()
        {
            string detailedBill = "";
            foreach (Coffee product in _order)
                detailedBill += product.ToString() +" Price: "+ product.Price + " Euro\n";

            return detailedBill;
        }
    }
}
