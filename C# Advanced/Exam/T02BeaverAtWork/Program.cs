using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] array = new char[n, n];
            int currentRow = 0;
            int currentCol = 0;
            List<char> collected = new List<char>();
            int pickedCounter=0;
            int countToCollect = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = char.Parse(input[j]);
                    if (array[i,j]=='B')
                    {
                        currentRow = i;
                        currentCol = j;
                    }
                    if (char.IsLower(array[i,j]))
                    {
                        countToCollect++;
                    }
                }
            }
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(array[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            while (countToCollect>pickedCounter)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }
                else
                {
                    if (command=="up")
                    {
                        if (currentRow<1)
                        {
                            if (collected.Count>0)
                            {
                                collected.RemoveAt(collected.Count - 1);
                            }
                        }
                        else
                        {
                            array[currentRow, currentCol] = '-';
                            currentRow--;
                            if (array[currentRow,currentCol]=='F')
                            {
                                if (currentRow!=0)
                                {
                                    array[currentRow, currentCol] = '-';
                                    currentRow = 0;
                                }
                                else
                                {
                                    array[currentRow, currentCol] = '-';
                                    currentRow = n - 1;
                                }
                            }
                            if (char.IsLower(array[currentRow,currentCol]))
                            {
                                collected.Add(array[currentRow, currentCol]);
                                pickedCounter++;
                            }
                            array[currentRow, currentCol] = 'B';
                        }
                    }




                    if (command == "down")
                    {
                        if (currentRow > n-2)
                        {
                            if (collected.Count > 0)
                            {
                                collected.RemoveAt(collected.Count - 1);
                            }
                        }
                        else
                        {
                            array[currentRow, currentCol] = '-';
                            currentRow++;
                            if (array[currentRow, currentCol] == 'F')
                            {
                                if (currentRow != n-1)
                                {
                                    array[currentRow, currentCol] = '-';
                                    currentRow = n-1;
                                }
                                else
                                {
                                    array[currentRow, currentCol] = '-';
                                    currentRow = 0;
                                }
                            }
                            if (char.IsLower(array[currentRow, currentCol]))
                            {
                                collected.Add(array[currentRow, currentCol]);
                                pickedCounter++;
                            }
                            array[currentRow, currentCol] = 'B';
                        }
                    }



                    if (command == "left")
                    {
                        if (currentCol < 1)
                        {
                            if (collected.Count > 0)
                            {
                                collected.RemoveAt(collected.Count - 1);
                            }
                        }
                        else
                        {
                            array[currentRow, currentCol] = '-';
                            currentCol--;
                            if (array[currentRow, currentCol] == 'F')
                            {
                                if (currentCol != 0)
                                {
                                    array[currentRow, currentCol] = '-';
                                    currentCol = 0;
                                }
                                else
                                {
                                    array[currentRow, currentCol] = '-';
                                    currentCol = n - 1;
                                }
                            }
                            if (char.IsLower(array[currentRow, currentCol]))
                            {
                                collected.Add(array[currentRow, currentCol]);
                                pickedCounter++;
                            }
                            array[currentRow, currentCol] = 'B';
                        }
                    }



                    if (command == "right")
                    {
                        if (currentCol > n-2)
                        {
                            if (collected.Count > 0)
                            {
                                collected.RemoveAt(collected.Count - 1);
                            }
                        }
                        else
                        {
                            array[currentRow, currentCol] = '-';
                            currentCol++;
                            if (array[currentRow, currentCol] == 'F')
                            {
                                if (currentCol != 0)
                                {
                                    array[currentRow, currentCol] = '-';
                                    currentCol = n-1;
                                }
                                else
                                {
                                    array[currentRow, currentCol] = '-';
                                    currentCol = 0;
                                }
                            }
                            if (char.IsLower(array[currentRow, currentCol]))
                            {
                                collected.Add(array[currentRow, currentCol]);
                                pickedCounter++;
                            }
                            array[currentRow, currentCol] = 'B';
                        }
                    }

                }
            }
            if (countToCollect==pickedCounter)
            {
                Console.WriteLine($"The Beaver successfully collect {collected.Count} wood branches: {string.Join(", ",collected)}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {countToCollect-pickedCounter} branches left.");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
