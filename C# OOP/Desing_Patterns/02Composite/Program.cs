using System;

namespace _02Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleGift ranger = new SingleGift(12, "Power-Ranger");
            SingleGift car = new SingleGift(50, "Car");

            CompositeGift compositeGift = new CompositeGift(0, "CompositeGifts");

            compositeGift.Add(ranger);
            compositeGift.Add(car);
            CompositeGift compositeGiftSecond = new CompositeGift(0, "CompositeGifts");

            compositeGiftSecond.Add(car);
            compositeGift.Add(compositeGiftSecond);
            Console.WriteLine(compositeGift.CalculateTotalPrice());


        }
    }
}
