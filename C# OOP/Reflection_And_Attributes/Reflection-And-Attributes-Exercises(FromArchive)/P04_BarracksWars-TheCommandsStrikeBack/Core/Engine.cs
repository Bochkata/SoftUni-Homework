namespace _03BarracksFactory.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

       
        private string InterpredCommand(string[] data, string commandName)
        {
            string commandFullName = commandName[0].ToString().ToUpper() + commandName.Substring(1) + "Command";
            Type type = Assembly.GetCallingAssembly().GetTypes().First(x => x.Name == commandFullName);
            IExecutable command = (IExecutable)Activator.CreateInstance(type, new object[] { data, repository, unitFactory });
            string result = command.Execute();
            return result;
            // string result = string.Empty;
            //switch (commandName)
            //{
            //    case "add":
            //        result = this.AddUnitCommand(data);
            //        break;
            //    case "report":
            //        result = this.ReportCommand(data);
            //        break;
            //    case "fight":
            //        Environment.Exit(0);
            //        break;
            //    default:
            //        throw new InvalidOperationException("Invalid command!");
            //}
            //return result;
        }


    }
}
