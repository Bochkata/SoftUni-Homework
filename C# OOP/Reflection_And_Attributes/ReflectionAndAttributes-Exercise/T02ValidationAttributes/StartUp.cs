using System;

namespace ValidationAttributes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Pesho", 16);

            bool isValidEntity = Validator.IsValid(person);

            Console.WriteLine(isValidEntity);
        }
    }
}
