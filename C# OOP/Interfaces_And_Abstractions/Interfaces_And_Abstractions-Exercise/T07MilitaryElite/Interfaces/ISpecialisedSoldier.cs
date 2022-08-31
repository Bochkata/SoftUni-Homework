

using T07MilitaryElite.Enums;

namespace T07MilitaryElite.Interfaces
{
    public interface ISpecialisedSoldier: IPrivate
    {
        public Corps Corps { get; set; }
    }
}
