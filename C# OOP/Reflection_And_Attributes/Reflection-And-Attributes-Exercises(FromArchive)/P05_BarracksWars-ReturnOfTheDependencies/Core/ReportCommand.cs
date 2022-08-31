using _03BarracksFactory.Contracts;
using P03_BarraksWars.Core.Factories;
using System;

namespace P03_BarraksWars.Core
{
    public class ReportCommand : Command
    {
        [Inject]            
        private IRepository repository;
        public ReportCommand(string[] data) : base(data)
        {
        }
        public IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }
        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
