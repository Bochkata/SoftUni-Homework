

using System;
using INStock.Contracts;

namespace INStock
{
    
    public class Product : IProduct
    {
        private string label;
        private decimal price;

        private int quantity;
        public Product(string label, decimal price, int quantity)
        {
            Label = label;
            Price = price;
            Quantity = quantity;
        }

        public string Label
        {
            get => label;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Label cannot be null, empty or whitespace");
                }

                label = value;
            }
        }
        public decimal Price
        {
            get => price;
            set
            {
                if (value <=0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative or zero");
                }

                price = value;
            }
        }
        public int Quantity {
            get => quantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity cannot be negative");
                }

                quantity = value;
            }
        }


        public int CompareTo(IProduct other)
        {
            int result = Price.CompareTo(other.Price);
            if (result == 0)
            {
                result = Quantity.CompareTo(other.Quantity);
            }

            return result;
        }
    }

}
