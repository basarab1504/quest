using System.Collections.Generic;

namespace quest
{

    class GiveCommand : ICommand
    {
        public void Execute(CommandArgs args)
        {
            var castedArgs = (GiveCommandArgs)args;
            if (castedArgs.Invoker.TryGet<InventoryBehavior>(out InventoryBehavior invokerBehavior))
            {
                List<string> strings = new List<string>(castedArgs.Items.Count);
                
                foreach (var item in castedArgs.Items)
                {
                    strings.Add(item.Title);
                    invokerBehavior.Remove(item);
                }
                
                System.Console.WriteLine($"{castedArgs.Invoker.Title} gave {string.Join(' ', strings)} to {castedArgs.GiveTo.Title}");

                World.Instance.Push(new CommandData()
                {
                    Command = new TakeCommand(),
                    Args = new TakeCommandArgs() { Invoker = castedArgs.GiveTo, TakeFrom = castedArgs.Invoker, Items = castedArgs.Items }
                });
            }
        }

        public CommandArgs Parse(string fullCommand)
        {
            var splitted = fullCommand.Split();

            var items = new List<GameObject>();

            foreach (var item in splitted[1..(splitted.Length - 1)])
            {
                if (World.Instance.TryGet<GameObject>(item, out GameObject foundObj))
                    items.Add(foundObj);
            }

            World.Instance.TryGet<GameObject>(splitted[splitted.Length - 1], out GameObject gameObject);

            return new GiveCommandArgs() { GiveTo = gameObject, Items = items };
        }
    }

    class GiveCommandArgs : CommandArgs
    {
        public GameObject GiveTo { get; set; }
        public IList<GameObject> Items { get; set; }
    }
}