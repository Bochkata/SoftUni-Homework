

using System;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

      
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

       public int Age
        {
            get
            {
                return age;
            }
            set
            {
               age = value;
            }
        }

       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();
           sb.AppendLine(string.Format($"Name: {Name}, Age: {Age}"));
           return sb.ToString().TrimEnd();
       }
    }
}
