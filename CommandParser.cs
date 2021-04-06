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

        public bool TryParse(GameObject invoker, string input, out ICommand command)
        {
            //упрощение
            string verb = input.Split()[0];
            if (!commands.TryGetValue(verb, out command))
            {
                System.Console.WriteLine("Avaliable commands:");
                foreach(var item in commands.Keys)
                    System.Console.WriteLine($"- {item}");
            }
            return command != null;
        }
    }
}
