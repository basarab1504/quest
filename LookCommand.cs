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
    }

    class LookCommandArgs : CommandArgs
    {
        public GameObject LookAt { get; set; }
    }
}
