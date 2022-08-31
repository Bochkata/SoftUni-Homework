using _03BarracksFactory.Contracts;

namespace P03_BarraksWars.Core
{
    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            Data = data;
            Repository = repository;
            UnitFactory = unitFactory;
        }

        protected string[] Data
        {
            get { return data; }
            private set { data = value; }
        }
        protected IRepository Repository
        {
            get { return repository; }
            private set { repository = value; }
        }
        protected IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            private set { unitFactory = value; }
        }
        public abstract string Execute();
    }
        
}
