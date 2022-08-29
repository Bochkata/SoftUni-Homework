using System;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            while (true)
            {
                var command = Console.ReadLine().Split(" ");
                if (command[0]=="End")
                {
                    
                    break;
                }
                else
                {
                    if (command[0]=="Translate")
                    {
                        input.Replace(command[1], command[2]);
                        Console.WriteLine(input);
                    }
                    if (command[0]=="Includes")
                    {
                        if (input.ToString().Contains(command[1]))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    if (command[0]=="Start")
                    {
                        if (input.ToString().StartsWith(command[1]))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    if (command[0]=="Lowercase")
                    {
                        string temp = input.ToString().ToLower();
                        input = new StringBuilder(temp);
                        Console.WriteLine(input);
                    }
                    if (command[0]=="FindIndex")
                    {
                        Console.WriteLine(input.ToString().LastIndexOf(command[1]));
                      
                    }
                    if (command[0]=="Remove")
                    {
                        input.Remove(int.Parse(command[1]), int.Parse(command[2]));
                        Console.WriteLine(input);
                    }
                }
            }
        }
    }
}