

using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {


        public string CollectGettersAndSetters(string className)
        {
            StringBuilder sb = new StringBuilder();
            Type hackerType = Type.GetType(className);
            MethodInfo[] methods = hackerType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            MethodInfo[] gettersMethods = methods.Where(x => x.Name.StartsWith("get")).ToArray();
            MethodInfo[] settersMethods = methods.Where(x => x.Name.StartsWith("set")).ToArray();
            foreach (MethodInfo getMethod in gettersMethods)
            {
                sb.AppendLine($"{getMethod.Name} will return {getMethod.ReturnType}");
            }

            foreach (MethodInfo setMethod in settersMethods)
            {
                sb.AppendLine($"{setMethod.Name} will set field of {setMethod.GetParameters().First().ParameterType}");
            }

            return sb.ToString().TrimEnd();
        }
    

    }
}
