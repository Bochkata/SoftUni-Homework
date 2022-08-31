using System;
using System.Collections.Generic;
using System.Text;

namespace _02Composite
{
    public interface IGiftOperations
    {
        void Add(GiftBase giftBase);
        void Remove(GiftBase giftBase);
    }
}
