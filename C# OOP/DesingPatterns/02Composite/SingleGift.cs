using System;
using System.Collections.Generic;
using System.Text;

namespace _02Composite
{
    public class SingleGift:GiftBase
    {
        public SingleGift(int price, string name) : base(price, name)
        {
        }

        public override int CalculateTotalPrice()
            => this.price;
    }
}
