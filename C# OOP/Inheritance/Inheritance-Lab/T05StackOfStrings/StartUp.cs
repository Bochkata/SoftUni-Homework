using System;
using System.Collections.Generic;


namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            StackOfStrings myStack = new StackOfStrings();

            Console.WriteLine(myStack.IsEmpty());

          
            myStack.AddRange(new List<string>() { "gosho", "pesho", "mandja", "nindja", "mana" });

            Console.WriteLine(myStack.IsEmpty());


        }
    }
}
