
using System.Collections.Generic;
using System.Text;
using T07MilitaryElite.Interfaces;

namespace T07MilitaryElite.Models
{
    public class LieutenantGeneral: Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastname, decimal salary) : base(id, firstName, lastname, salary)
        {
            Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; set; }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           sb.AppendLine(base.ToString());
           sb.AppendLine("Privates:");
            foreach (IPrivate item in Privates)
            {
                sb.AppendLine($"  {item}");
            }
           
            return sb.ToString().TrimEnd();
        }
    }
}
