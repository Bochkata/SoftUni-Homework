

using System;

using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();
            Type hackerType = Type.GetType(className);
            MethodInfo[] methods = hackerType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {hackerType.BaseType.Name}");
            foreach (MethodInfo method in methods)
            {

                sb.AppendLine(method.Name);

            }

            return sb.ToString().TrimEnd();
        }
    

    }
}
