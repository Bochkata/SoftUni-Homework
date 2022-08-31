using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Composite
{
    public class CompositeGift: GiftBase, IGiftOperations
    {

        private readonly List<GiftBase> giftBases;
        public CompositeGift(int price, string name) : base(price, name)
        {
            giftBases = new List<GiftBase>();
        }

        public void Add(GiftBase giftBase)
        {
            giftBases.Add(giftBase);
        }

        public void Remove(GiftBase giftBase)
        {
            giftBases.Remove(giftBase);
        }

        public override int CalculateTotalPrice() => this.giftBases.Sum(x => x.CalculateTotalPrice());

    }
}
