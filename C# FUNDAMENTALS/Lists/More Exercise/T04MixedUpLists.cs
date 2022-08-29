using System;
using System.Collections.Generic;
using System.Linq;

namespace T04MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> firstLineNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            List<int> secondLineNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            List<int> newList = new List<int>();
            List<int> remainingTwoNumbers = new List<int>();

            int lessLength = secondLineNumbers.Count;
            remainingTwoNumbers.Add(firstLineNumbers[firstLineNumbers.Count - 1]);
            remainingTwoNumbers.Add(firstLineNumbers[firstLineNumbers.Count - 2]);

            if (firstLineNumbers.Count < secondLineNumbers.Count)
            {
                lessLength = firstLineNumbers.Count;
                remainingTwoNumbers.Clear();
                remainingTwoNumbers.Add(secondLineNumbers[0]);
                remainingTwoNumbers.Add(secondLineNumbers[1]);
            }

            secondLineNumbers.Reverse();

            for (int i = 0; i < lessLength; i++)
            {
                newList.Add(firstLineNumbers[i]);
                newList.Add(secondLineNumbers[i]);
            }

            List<int> finalList = new List<int>();

            int smallerNumber = remainingTwoNumbers[0];
            int biggerNumber = remainingTwoNumbers[1];
            if (remainingTwoNumbers[0] >= remainingTwoNumbers[1])
            {
                smallerNumber = remainingTwoNumbers[1];
                biggerNumber = remainingTwoNumbers[0];
            }


            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] > smallerNumber && newList[i] < biggerNumber)
                {
                    finalList.Add(newList[i]);
                }
            }
            finalList.Sort();
            Console.WriteLine(string.Join(" ", finalList));

        }
    }
}
