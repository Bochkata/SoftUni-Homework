
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using CommandPattern.Core.Contracts;

namespace CommandPattern
{
    public class CommandInterpreter: ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string commandName = tokens[0] + "Command";

            string[] performances = tokens.Skip(1).ToArray();

            Type type = Assembly.GetCallingAssembly().GetTypes().Where(x => x.Name == commandName).FirstOrDefault();
            if (type == null)
            {
                throw new InvalidOperationException("Invalid command");
            }

           

            ICommand command = Activator.CreateInstance(type) as ICommand;

            string result = command.Execute(performances);
            //if (commandName == nameof(HelloCommand))
            //{
            //    command = new HelloCommand();
            //    result = command.Execute(performances);
            //}

            return result;

        }
    }
}
