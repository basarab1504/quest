namespace quest
{
    class HearCommand : ICommand
    {
        public string Pattern => "not implemented yet ;]";

        public void Execute(CommandArgs args)
        {
            var castedArgs = (HearCommandArgs)args;
            
            if (castedArgs.From == null)
                return;

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
