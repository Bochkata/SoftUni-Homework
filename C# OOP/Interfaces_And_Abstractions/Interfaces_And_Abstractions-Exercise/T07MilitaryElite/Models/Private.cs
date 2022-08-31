
using T07MilitaryElite.Interfaces;

namespace T07MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastname, decimal salary) : base(id, firstName, lastname)
        {
            Salary = salary;
        }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {Lastname} Id: {ID} Salary: {Salary:f2}";
        }
    }
}
