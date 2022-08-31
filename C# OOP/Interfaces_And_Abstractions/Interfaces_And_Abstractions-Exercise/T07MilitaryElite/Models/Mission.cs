
using T07MilitaryElite.Enums;
using T07MilitaryElite.Interfaces;

namespace T07MilitaryElite.Models
{
    public class  Mission: IMission
    {
        public Mission(string codeName, MissionState missionState)
        {
            CodeName = codeName;
            MissionState = missionState;
        }

        public string CodeName { get; set; }
        public MissionState MissionState { get; set; }
        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {MissionState}";

        }
    }
}
