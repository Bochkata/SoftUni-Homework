using System;
using System.Collections.Generic;
using System.Linq;


namespace T03MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> mergedList = new List<int>(nums1.Count + nums2.Count);

            if (nums1.Count >= nums2.Count)
            {
                for (int i = 0; i < nums1.Count; i++)
                {
                    mergedList.Add(nums1[i]);
                    if (i < nums2.Count)
                    {
                        mergedList.Add(nums2[i]);
                    }

                }
            }

            else
            {
                for (int i = 0; i < nums2.Count; i++)
                {
                    if (i < nums1.Count)
                    {
                        mergedList.Add(nums1[i]);
                    }
                    mergedList.Add(nums2[i]);

                }
            }

            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
