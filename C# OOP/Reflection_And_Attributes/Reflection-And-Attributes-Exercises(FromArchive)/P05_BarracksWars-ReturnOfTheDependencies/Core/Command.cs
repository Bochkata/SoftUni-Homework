using _03BarracksFactory.Contracts;

namespace P03_BarraksWars.Core
{
    public abstract class Command : IExecutable
    {
        private string[] data;

        protected Command(string[] data)
        {
            Data = data;
        }

        protected string[] Data
        {
            get { return data; }
            private set { data = value; }
        }

        public abstract string Execute();
    }

}
