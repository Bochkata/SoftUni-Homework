using System;
using System.Xml.Serialization;

namespace T09GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            if (valueType == "int")
            {
                Console.WriteLine(GetMax(int.Parse(value1), int.Parse(value2)));
            }

            if (valueType == "char")
            {
                Console.WriteLine(GetMax(char.Parse(value1), char.Parse(value2)));
            }

            if (valueType == "string")
            {
                Console.WriteLine(GetMax(value1, value2));
            }
        }

        //    string valueType = Console.ReadLine();
            //    if (valueType == "int")
            //    {
            //        int num1 = int.Parse(Console.ReadLine());
            //        int num2 = int.Parse(Console.ReadLine());
            //        int result = GetMax(num1, num2);
            //        Console.WriteLine(result);
            //    }

            //    if (valueType == "char")
            //    {
            //        char value1 = char.Parse(Console.ReadLine());
            //        char value2 = char.Parse(Console.ReadLine());
            //        char result = GetMax(value1, value2);
            //        Console.WriteLine(result);

            //    }

            //    if (valueType == "string")
            //    {
            //        string str1 = Console.ReadLine();
            //        string str2 = Console.ReadLine();
            //        string result = GetMax(str1, str2);
            //        Console.WriteLine(result);

            //    }
            //}

            static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;

            }
            else 
            {
                return b;
            }

        }

        static char GetMax(char a, char b)
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
           

        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
        
    }

      
    }
