using System;
using System.Numerics;

namespace T02BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Factorial factorial = new Factorial(N);

            Console.WriteLine(factorial.FactorialCalcMethod());
        }

    

    class Factorial
        {
            public Factorial(int m)
            {
                N = m;
            }


            public int N { get; set; }

            public BigInteger FactorialCalcMethod()
            {
                BigInteger factorial = 1;
                for (int i = 2; i <= N; i++)
                {
                    factorial *= i;
                }

                return factorial;
            }
        }
    }
}
