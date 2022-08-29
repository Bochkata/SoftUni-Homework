using System;

namespace T06BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int openingBrackets = 0;
            int closingBrackets = 0;
            bool balanced = true;
            int consequativeOpening = 0;
            int consequativeClosing = 0;

            for (int i = 0; i < number; i++)
            {
                
                string input = Console.ReadLine();
                if (input == "(")
                {
                    openingBrackets++;
                    
                    consequativeOpening++;
                    if (consequativeOpening == 2)
                    {
                        balanced = false;
                    }

                    consequativeClosing = 0;
                }
                else if (input == ")")
                {
                    closingBrackets++;
                    consequativeClosing++;
                    if (consequativeClosing == 2)
                    {
                        balanced = false;
                    }
                    
                    consequativeOpening = 0;
                    
                }
                
            }
            
            if (balanced && openingBrackets == closingBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }


        }
    }
}
