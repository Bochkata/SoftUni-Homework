using System;


namespace T07NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            NxNMatrix(input);
        }

        static void NxNMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }

        }


    }
}
