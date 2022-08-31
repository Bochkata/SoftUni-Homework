using _03BarracksFactory.Contracts;
using P03_BarraksWars.Core.Factories;
using System;

namespace P03_BarraksWars.Core
{
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;
        public RetireCommand(string[] data) : base(data)
        {
        }
     
        public override string Execute()
        {
            
            try
            {
                string unitType = Data[1];
                repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
               
            }
            

        }
    }
}
