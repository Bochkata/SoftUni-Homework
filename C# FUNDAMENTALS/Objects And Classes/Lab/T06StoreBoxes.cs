using System;
using System.Collections.Generic;
using System.Linq;


namespace T06StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<Box> box = new List<Box>();
            List<Box> sortedbox = new List<Box>();

            while (input[0] != "end")
            {

                int serialNumber = int.Parse(input[0]);
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                double itemPrice = double.Parse(input[3]);

                Item newArticle = new Item();
                {
                    newArticle.ItemName = itemName;
                    newArticle.ItemPrice = itemPrice;

                };

                Box newBox = new Box();
                {
                    newBox.SerialNumber = serialNumber;
                    newBox.Item.ItemName = itemName;
                    newBox.Item.ItemPrice = itemPrice;
                    newBox.Quantity = itemQuantity;
                    newBox.BoxPrice = itemPrice * itemQuantity;
                     
                }

                box.Add(newBox);
                
                
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            sortedbox = box.OrderByDescending(el => el.BoxPrice).ToList();

            foreach (Box boxSorted in sortedbox)
            {
                Console.WriteLine($"{boxSorted.SerialNumber}\n-- {boxSorted.Item.ItemName} " +
                                  $"- ${boxSorted.Item.ItemPrice:f2}: {boxSorted.Quantity}\n-- ${boxSorted.BoxPrice:f2}");
            }
            
        }
        class Box
        {
            public Box()
            {
                Item = new Item();

            }
            public int SerialNumber { get; set; }
            public Item Item { get; set; }
            public int Quantity { get; set; }
            public double BoxPrice { get; set; }

        }
        class Item
        {
            public string ItemName { get; set; }
            public double ItemPrice { get; set; }
        }
    }
}
