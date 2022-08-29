using System;

namespace T03Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPersons = int.Parse(Console.ReadLine());
            int personsCapacity = int.Parse(Console.ReadLine());

            int countCourses = 0;

            if (numberOfPersons <= personsCapacity)
            {
                countCourses = 1;
            }
            else
            {

                if (numberOfPersons % personsCapacity == 0)
                {
                    countCourses = numberOfPersons / personsCapacity;
                }
                else
                {
                    countCourses = numberOfPersons / personsCapacity + 1;
                }

            }
            Console.WriteLine(countCourses);

        }
    }
}
