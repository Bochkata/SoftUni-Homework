using System;
using System.Collections.Generic;
using System.Linq;

namespace T03MergingListsVer2
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

            int biggerListCount = nums1.Count;
            if (nums1.Count < nums2.Count)
            {
                biggerListCount = nums2.Count;
            }

            for (int i = 0; i < biggerListCount; i++)
            {
                //mergedList.Add(nums1[i]);
                //mergedList.Add(nums2[i]);

                if (nums1.Count > i)
                {
                    mergedList.Add(nums1[i]);
                }
                if (nums2.Count > i)
                {
                    mergedList.Add(nums2[i]);
                }

            }

            Console.WriteLine(string.Join(" ", mergedList));


        
        }
    }
}
