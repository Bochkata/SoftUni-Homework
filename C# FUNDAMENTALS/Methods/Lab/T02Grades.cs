using System;

namespace T02Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grades(grade);
        }

        static void Grades(double grade)
        {

            string result = " ";
            if (grade >= 2.00 && grade <= 2.99)
            {
                result = "Fail";
            }
            else if (grade >= 3 && grade <= 3.49)

            {
                result = "Poor";
            }

            else if (grade >= 3.50 && grade <= 4.49)

            {
                result = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)

            {
                result = "Very good";
            }

            else if (grade >= 5.50 && grade <= 6.00)

            {
                result = "Excellent";
            }

            Console.WriteLine(result);

        }
    }
}
