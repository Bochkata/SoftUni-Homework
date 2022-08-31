
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T07MilitaryElite.Enums;
using T07MilitaryElite.Interfaces;

namespace T07MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastname, decimal salary, Corps corps) : base(id, firstName, lastname, salary, corps)
        {
            Missions = new List<IMission>();
        }

        public List<IMission> Missions { get; set; }

        public void CompleteMission(string CodeName)
        {
            IMission mission = Missions.FirstOrDefault(x => x.CodeName == CodeName);
            mission.MissionState = MissionState.Finished;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");
            foreach (IMission item in Missions)
            {
                sb.AppendLine($"  {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
