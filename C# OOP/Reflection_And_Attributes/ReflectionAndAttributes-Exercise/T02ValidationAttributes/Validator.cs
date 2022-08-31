

using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = obj.GetType();

            PropertyInfo[] propertiesInfo = type.GetProperties();

            foreach (PropertyInfo property in propertiesInfo)
            {
                object[] attributes = property.GetCustomAttributes(false);
                Object objectValue = property.GetValue(obj);
                foreach (MyValidationAttribute attribute in attributes.Cast<MyValidationAttribute>())
                {
                   
                    if (!attribute.IsValid(objectValue))
                    {
                        return false;
                    }

                }
                
            }
            
            return true;
        }
    }
}
