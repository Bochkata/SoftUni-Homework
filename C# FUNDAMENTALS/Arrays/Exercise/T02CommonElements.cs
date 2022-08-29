using System;

namespace T02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string [] array2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    for (int j = 0; j < array1.Length; j++)
            //        {
            //            if (array2[i] == array1[j])
            //            {
            //                Console.Write($"{array2[i]} ");

            //            }
            //    }
            //}



            foreach (var elementsArray2 in array2)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    string elementsArray1 = array1[i];
                    if (elementsArray2 == elementsArray1)
                    {
                        Console.Write(elementsArray2 + " ");
                    }
                }
            }


            //foreach (var elementsArray2 in array2)
            //{
            //    foreach (var elementsArray1 in array1)
            //    {
            //        if (elementsArray2 == elementsArray1)
            //        {
            //            Console.Write(elementsArray2 + " ");
            //        }
            //    }
            //}


        }
    }
}
