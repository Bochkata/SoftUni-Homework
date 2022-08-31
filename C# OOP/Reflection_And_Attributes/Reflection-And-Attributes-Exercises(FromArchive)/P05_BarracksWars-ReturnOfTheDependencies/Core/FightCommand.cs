using _03BarracksFactory.Contracts;
using System;

namespace P03_BarraksWars.Core
{
    public class FightCommand : Command
    {
        public FightCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return null;
        }
    }
}
