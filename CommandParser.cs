using System.Collections.Generic;

namespace quest
{
    class CommandParser
    {
        private Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();

        public bool TryAddCommand(string word, ICommand command)
        {
            return commands.TryAdd(word, command);
        }

        public bool TryParse(GameObject invoker, string input, out CommandData data)
        {
            //упрощение
            var splitted = input.Split();
            data = new CommandData();

            string verb = splitted[0];
            if (!commands.TryGetValue(verb, out ICommand command))
            {
                System.Console.WriteLine("Avaliable commands:");
                foreach (var item in commands.Keys)
                    System.Console.WriteLine($"- {item}");
            }
            else
            {
                data.Command = command;
            }

            data.Args = new CommandArgs();
            data.Args.Invoker = invoker;
            if (splitted.Length > 3 && World.Instance.TryGet<GameObject>(splitted[splitted.Length - 1], out GameObject gameObject))
            {
                data.Args.ToInteract = gameObject;
                data.Args.Message = string.Join(' ', splitted[1..(splitted.Length - 1)]);
            }
            
            return command != null;
        }
    }
}
