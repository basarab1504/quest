namespace quest
{
    class LookCommand : ICommand
    {
        public void Execute(CommandArgs args)
        {
            var castedArgs = (LookCommandArgs)args;
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
