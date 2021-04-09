namespace quest
{
    class HearCommand : ICommand
    {
        public void Execute(CommandArgs args)
        {
            if (args.Invoker.TryGet<HearingBehavior>(out HearingBehavior hearingBehavior))
                hearingBehavior.Process(args);
            else
                System.Console.WriteLine($"{args.Invoker.Title} can't hear.");
        }

        public CommandArgs Parse(string fullCommand)
        {
            throw new System.NotImplementedException();
        }
    }

    class HearCommandArgs : CommandArgs
    {
        public GameObject From { get; set; }
        public string Message { get; set; }
    }
}
