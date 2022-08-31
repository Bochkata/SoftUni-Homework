

namespace T07MilitaryElite.Models
{
    public abstract class Soldier :ISoldier
    {
        protected Soldier(string id, string firstName, string lastname)
        {
            ID = id;
            FirstName = firstName;
            Lastname = lastname;
        }

        public string ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
    }
}
