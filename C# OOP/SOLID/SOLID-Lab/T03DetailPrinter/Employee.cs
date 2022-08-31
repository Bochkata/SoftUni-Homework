using System;


namespace P03.DetailPrinter
{
    public class Employee: IPrintable
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
