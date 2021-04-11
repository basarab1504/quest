namespace quest
{
    class LookCommand : ICommand
    {
        public string Pattern => "*command* *object to look*";

        public void Execute(CommandArgs args)
        {
            var castedArgs = (LookCommandArgs)args;

            if (castedArgs.LookAt == null || !castedArgs.Invoker.Room.Contains(castedArgs.LookAt))
            {
                System.Console.WriteLine($"{castedArgs.Invoker.Title} сan't find with a look what {castedArgs.Invoker.Title} was looking for.");
                return;
            }

            if (args.Invoker.TryGet<SightBehavior>(out SightBehavior behavior))
            {
                behavior.Process(castedArgs);
            }
            else
                System.Console.WriteLine($"{args.Invoker.Title} can't see.");
        }

        public CommandArgs Parse(string fullCommand)
        {
            var splitted = fullCommand.Split();

            World.Instance.TryGet<GameObject>(splitted[splitted.Length - 1], out GameObject gameObject);

            return new LookCommandArgs() { LookAt = gameObject };
        }
    }

    class LookCommandArgs : CommandArgs
    {
        public GameObject LookAt { get; set; }
    }
}
