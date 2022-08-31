

using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
   public class Tracker : Attribute
    {
        public void PrintMethodsByAuthor()
        {
            StringBuilder sb = new StringBuilder();
            Type type = Type.GetType("AuthorProblem.StartUp");

            MethodInfo[] methods = type.GetMethods();
          

            foreach (MethodInfo method in methods)
            {
                if (method.CustomAttributes.Any(x=>x.AttributeType == typeof(AuthorAttribute)))
                {
                    object[] attributes = method.GetCustomAttributes(false);
                    foreach (AuthorAttribute attribute in attributes)
                    {
                        Console.WriteLine($"{method.Name} is written by {attribute.Name}" );
                    }
                }

            }
            
        }
    }
}
