

using T07MilitaryElite.Enums;
using T07MilitaryElite.Interfaces;

namespace T07MilitaryElite.Models
{
    public class SpecialisedSoldier: Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastname, decimal salary, Corps corps) : base(id, firstName, lastname, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; set; }
    }
}
