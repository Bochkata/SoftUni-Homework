using _03BarracksFactory.Contracts;

namespace P03_BarraksWars.Core.Factories
{
    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;
        [Inject]
        private IUnitFactory unitFactory;
        public AddCommand(string[] data) : base(data)
        {
        }
        public IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            set { unitFactory = value; }
        }

        public IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }
        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }

    }
}
