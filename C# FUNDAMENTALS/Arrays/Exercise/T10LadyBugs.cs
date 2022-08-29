using System;
using System.Linq;


namespace T10LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {

            int sizeOfField = int.Parse(Console.ReadLine());

            int[] fieldSize = new int[sizeOfField];

            int[] ladyBugsPositionsInField_Contain1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();


            int occupiedIndexesinField = 0;

            for (int i = 0; i < ladyBugsPositionsInField_Contain1.Length; i++)
            {
                occupiedIndexesinField = ladyBugsPositionsInField_Contain1[i];
                if (occupiedIndexesinField >= 0 && occupiedIndexesinField < fieldSize.Length)
                {

                    fieldSize[occupiedIndexesinField] = 1;
                }
            }

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "end")
                {
                    break;
                }

                string[] command = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int bugCurrentIndex = int.Parse(command[0]);
                string directionToMove = command[1];
                int bugPositionChangeInterval = int.Parse(command[2]);


                if (bugCurrentIndex >= 0 && bugCurrentIndex < fieldSize.Length)
                {
                    if (fieldSize[bugCurrentIndex] == 0)
                    {
                        continue;
                    }
                    else if (fieldSize[bugCurrentIndex] == 1)
                    {
                        bool isFlyingOff = true;
                        while (bugCurrentIndex >= 0 && bugCurrentIndex < fieldSize.Length)
                        {
                            if (isFlyingOff)
                            {
                                fieldSize[bugCurrentIndex] = 0;
                                isFlyingOff = false;
                            }


                            if (directionToMove == "right")

                            {

                                bugCurrentIndex += bugPositionChangeInterval;

                                if (bugCurrentIndex < 0 || bugCurrentIndex > fieldSize.Length - 1)
                                {

                                    break;

                                }
                                else if (bugCurrentIndex >= 0 && bugCurrentIndex <= fieldSize.Length - 1)
                                {

                                    if (fieldSize[bugCurrentIndex] == 0)
                                    {
                                        fieldSize[bugCurrentIndex] = 1;
                                        break;

                                    }
                                    else if (fieldSize[bugCurrentIndex] == 1)
                                    {
                                        continue;
                                    }
                                }

                            }

                            else if (directionToMove == "left")

                            {

                                bugCurrentIndex -= bugPositionChangeInterval;

                                if (bugCurrentIndex < 0 || bugCurrentIndex > fieldSize.Length - 1)
                                {
                                    break;

                                }
                                else if (bugCurrentIndex >= 0 && bugCurrentIndex <= fieldSize.Length - 1)
                                {

                                    if (fieldSize[bugCurrentIndex] == 0)
                                    {
                                        fieldSize[bugCurrentIndex] = 1;
                                        break;

                                    }
                                    else if (fieldSize[bugCurrentIndex] == 1)
                                    {
                                        continue;
                                    }
                                }

                            }


                        }

                    }

                }
            }


            Console.WriteLine(string.Join(" ", fieldSize));
        }

    }
}
