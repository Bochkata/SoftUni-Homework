using System;

namespace T01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsNumberN = int.Parse(Console.ReadLine());
            int totalNumberOfPassengers = 0;
            int[] passengersPerWagon = new int[wagonsNumberN];
            
            for (int i = 0; i < wagonsNumberN; i++)
            {
                passengersPerWagon[i] = int.Parse(Console.ReadLine());
                totalNumberOfPassengers += passengersPerWagon[i];
               
            }

            for (int i = 0; i < wagonsNumberN; i++)
            {
                Console.Write($"{passengersPerWagon[i]} ");
              

            }

            Console.WriteLine();
            Console.WriteLine("{0}", totalNumberOfPassengers);

        }
    }
}
