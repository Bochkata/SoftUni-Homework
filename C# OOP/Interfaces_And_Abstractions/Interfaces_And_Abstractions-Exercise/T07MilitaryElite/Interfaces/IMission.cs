
using T07MilitaryElite.Enums;

namespace T07MilitaryElite.Interfaces
{
    public interface IMission
    {
        public string CodeName { get; set; }
        public   MissionState MissionState{ get; set; }

    }
}
