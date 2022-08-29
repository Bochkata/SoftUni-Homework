using System;


namespace T09PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                isPalindrome(input);
                Console.WriteLine(isPalindrome(input) ? "true": "false");



                input = Console.ReadLine();
            }
        }

           

        static bool isPalindrome(string command)
        {
            for (int i = 0; i < command.Length/2; i++)
            {
                if (command[i] != command[command.Length-1 - i])
                {
                    return false;
                }
            }

            return true;


        }


    }
}
