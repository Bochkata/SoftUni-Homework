

using System.Text;
using T07MilitaryElite.Interfaces;

namespace T07MilitaryElite.Models
{
    public class Spy: Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastname, int codeNumber) : base(id, firstName, lastname)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; set; }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {Lastname} Id: {ID}");
            sb.AppendLine($"Code Number: {CodeNumber}");
            return sb.ToString().TrimEnd();
        }
    }
}
