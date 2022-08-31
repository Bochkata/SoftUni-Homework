using System;
using System.Collections.Generic;
using System.Text;

namespace _02Composite
{
    public  abstract class GiftBase
    {
        protected string name;
        protected int price;

        protected GiftBase(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public abstract int CalculateTotalPrice();

    }
}
