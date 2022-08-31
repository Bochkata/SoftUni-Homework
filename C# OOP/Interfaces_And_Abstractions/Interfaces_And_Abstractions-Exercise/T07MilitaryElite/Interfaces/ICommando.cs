
using System.Collections.Generic;


namespace T07MilitaryElite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        public List<IMission> Missions { get; set; }
        public void CompleteMission(string CodeName);

    }
}
