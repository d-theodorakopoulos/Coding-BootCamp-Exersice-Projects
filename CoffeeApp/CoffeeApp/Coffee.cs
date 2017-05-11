using System;

namespace CoffeeApp
{
    public enum CoffeeVariation {Small = 100,Normal = 150, Double = 300};
    public enum CoffeePrice { Small = 50,Normal = 150, Double = 250};

    public class Coffee
    {
        private CoffeeVariation _variation;
        private CoffeePrice _price;

        public CoffeeVariation Variation
        {
            get
            {
                return _variation;
            }
        }

        public float Price
        {
            get
            {
                return (float)_price/100f;
            }
        }

        public Coffee ()
        {
            _variation = CoffeeVariation.Normal;
            _price = CoffeePrice.Normal;
        }

        public Coffee (CoffeeVariation variation)
        {
            _variation = variation;
            CoffeeVariationToCoffeePrice();
        }

        private void CoffeeVariationToCoffeePrice()
        {
            if (Variation == CoffeeVariation.Small)
                _price = CoffeePrice.Small;
            else if (Variation == CoffeeVariation.Normal)
                _price = CoffeePrice.Normal;
            else
                _price = CoffeePrice.Double;
        }

        public override string ToString ()
        {
            return string.Format("This coffee is {0} ml",(int) Variation);
        }
    }
}
