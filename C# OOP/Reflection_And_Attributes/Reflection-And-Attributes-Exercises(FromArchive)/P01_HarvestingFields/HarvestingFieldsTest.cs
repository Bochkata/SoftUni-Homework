namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "HARVEST")
            {
                Type type = typeof(HarvestingFields);

                FieldInfo[] fieldsInfo = null;

                if (input == "private")
                {
                    fieldsInfo = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.IsPrivate).ToArray();
                }
                else if (input == "protected")
                {

                    fieldsInfo = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.IsFamily).ToArray();
                }
                else if (input == "public")
                {
                    fieldsInfo = type.GetFields(BindingFlags.Public | BindingFlags.Instance).Where(x => x.IsPublic).ToArray();
                }
                else if (input == "all")
                {
                    fieldsInfo = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                }
                foreach (FieldInfo field in fieldsInfo)
                {
                    string accessModifier = field.IsPrivate ? "private" : field.IsPublic ? "public" : "protected";
                    Console.WriteLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
                }

            }

        }
    }
}

