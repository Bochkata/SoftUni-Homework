
using System;

namespace T04WildFarm.Models
{
    public abstract class Food
    {
        private int quantity;
        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (quantity < 0)
                {
                    throw new ArgumentException();
                }

                quantity = value;
            }
        }

    }
}
