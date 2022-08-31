using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string currName = Console.ReadLine();
            int currAge = int.Parse(Console.ReadLine());


            if (currAge < 0)
            {
                return;
            }
            Person person;
            if (currAge <=15)
            {
                person = new Child(currName, currAge);
            }
            else
            {
                person = new Person(currName, currAge);
            }

            Console.WriteLine(person);
        }
    }
}