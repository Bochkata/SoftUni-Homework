
using T07MilitaryElite.Interfaces;

namespace T07MilitaryElite.Models
{
    public class Repair: IRepair
    {
        public Repair(string partname, int hoursWorked)
        {
            PartName = partname;
            HoursWorked = hoursWorked;
        }

       public string PartName { get; set; }
        public int HoursWorked { get; set; }
        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
        }
    }
}
