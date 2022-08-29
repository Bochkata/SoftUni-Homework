using System;

namespace T01SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int print1 = int.MinValue;
            int print2 = int.MinValue;
            int print3 = int.MinValue;

            if (n1 >= n2 && n1 >= n3)
            {
                print1 = n1;
            }
            else if (n2 >= n1 && n2 >=n3)
            {
                print1 = n2;
            }
            else if (n3 >= n1 && n3 >= n2)
            {
                print1 = n3;
            }

            if ((n1 >= n2 && n1 <= n3) || (n1 <= n2 && n1 >= n3))
            {
                print2 = n1;

            }
            else if ((n2 >= n1 && n2 <= n3) || (n2 <=n1 && n2 >= n3))
            {
                print2 = n2;

            }
            else if ((n3 >= n1 && n3 <= n2) || (n3 <= n1 && n3 >=n2))
            {
                print2 = n3;

            }
            if (n1 <= n2 && n1 <= n3)
            {
                print3 = n1;

            }
            else if (n2 <= n1 && n2 <= n3)
            {
                print3 = n2;

            }
            else if (n3 <= n1 && n3 <=n2)
            {
                print3 = n3;

            }
            Console.WriteLine(print1);
            Console.WriteLine(print2);
            Console.WriteLine(print3);


        }
    }
}
