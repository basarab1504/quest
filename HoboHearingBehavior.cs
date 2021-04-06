namespace quest
{
    class HoboHearingBehavior : HearingBehavior
    {
        public override void Process(CommandArgs args)
        {
            var castedArgs = (HearCommandArgs)args;
            World.Instance.Push(new CommandData() { Invoker = args.Invoker, Command = new SayCommand(), FullCommand = $"say Ugh? {castedArgs.From.Title}" });
        }
    }
}
