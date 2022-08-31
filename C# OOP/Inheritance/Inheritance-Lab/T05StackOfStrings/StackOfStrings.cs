using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public Stack<string> AddRange(IEnumerable<string> list)
        {
            foreach (string item in list)
            {
                this.Push(item);
            }

            return this;
        }
        
    }
}
