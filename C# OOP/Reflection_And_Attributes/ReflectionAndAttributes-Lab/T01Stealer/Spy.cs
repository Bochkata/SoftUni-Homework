

using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {

       
        
        public string StealFieldInfo(string classToInvestigate, params string[] fieldsNames)
        {
            StringBuilder sb = new StringBuilder();

            Type hackerType = Type.GetType(classToInvestigate);
            FieldInfo[] neededFields = hackerType.GetFields(BindingFlags.Static | BindingFlags.Public |
                                                            BindingFlags.NonPublic | BindingFlags.Instance);
            object inst = Activator.CreateInstance(hackerType, null);
            sb.AppendLine($"Class under investigation: {classToInvestigate}");

            foreach (FieldInfo field in neededFields.Where(x=>fieldsNames.Contains(x.Name)))
            {
               sb.AppendLine($"{field.Name} = {field.GetValue(inst)}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
