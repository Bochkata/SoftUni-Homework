

namespace T09ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        string IPerson.GetName() => $"{Name}";

        string IResident.GetName() => $"Mr/Ms/Mrs {Name}";

    }
}
