using System.Collections.Generic;

namespace _03BarracksFactory.Core
{
    using Contracts;
    using P03_BarraksWars.Core.Factories;
    using System;
    using System.Linq;
    using System.Reflection;

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
            IExecutable command = Activator.CreateInstance(type, new object[] { data }) as IExecutable;

            IEnumerable<FieldInfo> fieldsToInject = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
               .Where(f => f.GetCustomAttributes().Any(ca => ca.GetType() == typeof(InjectAttribute)));

            foreach (FieldInfo field in fieldsToInject)
            {
                object fieldValue = typeof(Engine).GetField(field.Name, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(this);
                field.SetValue(command, fieldValue);
            }
            string result = command.Execute();
            return result;

        }

    }
}
