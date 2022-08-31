
using System.Collections.Generic;


namespace T07MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral: IPrivate
    {
        public List<IPrivate> Privates { get; set; }
    }
    
}
