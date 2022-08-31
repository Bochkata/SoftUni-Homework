using System;
using System.Collections.Generic;


namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public Random random { get; set; } = new Random();

        public string RandomString()
        {
            int index = random.Next(0, Count);
            string list = base[index];
            base.RemoveAt(index);
            return list;
        }

    }
}
