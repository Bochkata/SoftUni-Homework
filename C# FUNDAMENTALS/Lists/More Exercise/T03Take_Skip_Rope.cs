using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace T03Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            StringBuilder text = new StringBuilder();
            string numbers = String.Empty;

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if (Char.IsDigit(encryptedMessage[i]))
                {
                    numbers += encryptedMessage[i];
                }
                else
                {
                    text.Append(encryptedMessage[i]);
                }

            }

            string newText = text.ToString();

            StringBuilder decryptedMessage = new StringBuilder();

            int currentIndexInText = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (i % 2 == 0)
                {
                    if ((currentIndexInText + int.Parse(numbers[i].ToString())) > newText.Length)
                    {
                        decryptedMessage.Append(newText.Substring(currentIndexInText));
                    }
                    else
                    {

                        decryptedMessage.Append(newText.Substring(currentIndexInText,
                            int.Parse(numbers[i].ToString())));
                        currentIndexInText += int.Parse(numbers[i].ToString()) + int.Parse(numbers[i + 1].ToString());
                    }
                }

            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
