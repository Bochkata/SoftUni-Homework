namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type type = Assembly.GetCallingAssembly().GetTypes().First(x => x.Name == unitType);
            IUnit unit = Activator.CreateInstance(type) as IUnit;
            return unit;

        }
    }
}
