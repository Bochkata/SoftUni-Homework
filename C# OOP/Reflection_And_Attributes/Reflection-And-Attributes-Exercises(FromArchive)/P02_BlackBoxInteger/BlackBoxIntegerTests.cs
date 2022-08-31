namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);

            BlackBoxInteger blackBoxInteger = (BlackBoxInteger)Activator.CreateInstance(type, true);
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split("_");
                string methodName = tokens[0];
                int figure = int.Parse(tokens[1]);
              
                MethodInfo currentMethod = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).First(x => x.Name == methodName);
                currentMethod.Invoke(blackBoxInteger, new object[] { figure });
                FieldInfo field = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).First(x => x.Name == "innerValue");
                int finalAmount = (int)field.GetValue(blackBoxInteger);
                Console.WriteLine(finalAmount);

            }



        }
    }
}
