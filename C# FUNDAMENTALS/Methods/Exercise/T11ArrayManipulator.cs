using System;

using System.Linq;




namespace T11ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "end")
            {

                if (command[0] == "exchange")
                {
                    int exchangeIndex = int.Parse(command[1]);
                    initialArray = ReversedArray(initialArray, exchangeIndex);


                }
                else if ((command[0] == "max" || command[0] == "min") && (command[1] == "even"
                                                                          || command[1] == "odd"))
                {

                    MinMaxEvenOddNumbers(initialArray, command[0], command[1]);
                }
                else if ((command[0] == "first" || command[0] == "last")
                         || (command[2] == "even" || command[2] == "odd"))
                {
                    int number = int.Parse(command[1]);
                    EvenOddNumbers(initialArray, command[0], number, command[2]);

                }



                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            }

            Console.WriteLine($"[{String.Join(", ", initialArray)}]");

        }


        static int[] ReversedArray(int[] array, int exchangeIndex)
        {
            int[] reversedArray = new int[array.Length];
            if (exchangeIndex >= array.Length || exchangeIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return array;

            }
            else
            {
                int reversedArrayIndex = 0;
                for (int i = exchangeIndex + 1; i < array.Length; i++)
                {
                    reversedArray[reversedArrayIndex] = array[i];
                    reversedArrayIndex++;
                }

                for (int i = 0; i <= exchangeIndex; i++)
                {
                    reversedArray[reversedArrayIndex] = array[i];
                    reversedArrayIndex++;
                }

                return reversedArray;
            }


        }

        static void MinMaxEvenOddNumbers(int[] array, string minOrMax, string evenOrOdd)
        {
            int indexOfNumber = -1;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            for (int i = 0; i < array.Length; i++)
            {

                if (minOrMax == "min" && min >= array[i])
                {
                    if (evenOrOdd == "even" && array[i] % 2 == 0)
                    {
                        min = array[i];
                        indexOfNumber = i;
                    }
                    else if (evenOrOdd == "odd" && array[i] % 2 != 0)
                    {
                        min = array[i];
                        indexOfNumber = i;
                    }
                }

                else if (minOrMax == "max" && max <= array[i])
                {
                    if (evenOrOdd == "even" && array[i] % 2 == 0)
                    {
                        max = array[i];
                        indexOfNumber = i;
                    }
                    else if (evenOrOdd == "odd" && array[i] % 2 != 0)
                    {
                        max = array[i];
                        indexOfNumber = i;
                    }
                }
            }

            if (indexOfNumber > -1)
            {
                Console.WriteLine(indexOfNumber);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void EvenOddNumbers(int[] array, string firstOrLast, int countNumbers, string evenOrOdd)
        {

            int[] arrayNew = new int[countNumbers];

            int countEvenOrOdd = 0;

            if (countNumbers > array.Length)
            {
                Console.WriteLine("Invalid count");

            }
            else
            {

                for (int i = 0; i < array.Length; i++)
                {

                    if (firstOrLast == "first")
                    {

                        if (evenOrOdd == "even" && array[i] % 2 == 0)
                        {
                            countEvenOrOdd++;

                            arrayNew[countEvenOrOdd - 1] = array[i];

                            if (countEvenOrOdd == countNumbers)
                            {

                                break;
                            }

                        }
                        else if (evenOrOdd == "odd" && array[i] % 2 != 0)
                        {
                            countEvenOrOdd++;
                            arrayNew[countEvenOrOdd - 1] = array[i];

                            if (countEvenOrOdd == countNumbers)
                            {

                                break;
                            }

                        }

                    }

                }
                
                for (int i = array.Length - 1; i >= 0; i--)
                {

                    if (firstOrLast == "last")
                    {
                        
                        if (evenOrOdd == "even" && array[i] % 2 == 0)
                        {
                            countEvenOrOdd++;
                            
                            arrayNew[countEvenOrOdd-1] = array[i];
                           

                            if (countEvenOrOdd == countNumbers)
                            {

                                break;
                            }

                        }
                        else if (evenOrOdd == "odd" && array[i] % 2 != 0)
                        {
                            countEvenOrOdd++;

                            arrayNew[countEvenOrOdd - 1] = array[i];

                            if (countEvenOrOdd == countNumbers)
                            {

                                break;
                            }

                        }

                    }

                    
                }
                if (countEvenOrOdd == 0)

                {
                    Console.WriteLine($"[]");
                }
                else
                {
                   
                    int[] finalArray = new int[countEvenOrOdd];
                    
                    for (int i = 0; i < finalArray.Length; i++)
                    {
                        finalArray[i] = arrayNew[i];
                        
                    }

                    arrayNew = finalArray;

                    if ((firstOrLast == "last" && evenOrOdd == "even") ||
                        (firstOrLast == "last" && evenOrOdd == "odd"))
                    {
                        for (int i = 0; i < arrayNew.Length / 2; i++)
                        {
                            var temp = arrayNew[i];
                            arrayNew[i] = arrayNew[arrayNew.Length - 1 - i];
                            arrayNew[arrayNew.Length - 1 - i] = temp;
                        }
                        //arrayNew = arrayNew.Reverse().ToArray();
                    }

                    Console.WriteLine($"[{String.Join(", ", arrayNew)}]");
                }
            }

        }

    }

}



