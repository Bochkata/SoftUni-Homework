using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace T07AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse().ToList();


            List<int> listNums = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                listNums.AddRange(list[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList());

            }


            Console.WriteLine(string.Join(" ", listNums));


        }
    }
}
