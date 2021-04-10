using System.Collections.Generic;

namespace quest
{
    class TakeCommand : ICommand
    {
        public void Execute(CommandArgs args)
        {
            var castedArgs = (TakeCommandArgs)args;
            if (castedArgs.Invoker.TryGet<InventoryBehavior>(out InventoryBehavior invokerBehavior))
            {
                List<string> strings = new List<string>(castedArgs.Items.Count);
                foreach (var item in castedArgs.Items)
                {
                    strings.Add(item.Title);
                    invokerBehavior.Remove(item);
                }
                System.Console.WriteLine($"{castedArgs.Invoker.Title} took {string.Join(' ', strings)} from {castedArgs.TakeFrom.Title}");
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

            return new TakeCommandArgs() { TakeFrom = gameObject, Items = items };
        }
    }

    class TakeCommandArgs : CommandArgs
    {
        public GameObject TakeFrom { get; set; }
        public IList<GameObject> Items { get; set; }
    }
}

