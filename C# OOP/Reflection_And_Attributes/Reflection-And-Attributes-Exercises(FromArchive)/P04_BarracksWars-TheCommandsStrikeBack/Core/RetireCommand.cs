using _03BarracksFactory.Contracts;
using System;

namespace P03_BarraksWars.Core
{
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            
            try
            {
                string unitType = Data[1];
                Repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
               
            }
            

        }
    }
}
