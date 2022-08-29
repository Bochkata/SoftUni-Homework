using System;
using System.Text;
using System.Text.RegularExpressions;

namespace T04Santa_sSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToDecrease = int.Parse(Console.ReadLine());

            string command = String.Empty;

            while((command = Console.ReadLine()) != "end")
            {
                StringBuilder decryptedMessage = new StringBuilder();

                for (int i = 0; i < command.Length; i++)
                { 
                    decryptedMessage.Append((char)(command[i] - numberToDecrease));
                }

                string finalMessage = decryptedMessage.ToString();
                string pattern =
                    @"[^\@\-\!\:\>]*@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*!(?<behavior>G|N)![^\@\-\!\:\>]*";

                Regex regex = new Regex(pattern);
                Match output = regex.Match(finalMessage);
                if (output.Success && output.Groups["behavior"].Value == "G")
                {
                    Console.WriteLine(output.Groups["name"]);
                }




            }
        }
    }
}
