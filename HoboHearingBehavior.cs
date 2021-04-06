namespace quest
{
    class HoboHearingBehavior : HearingBehavior
    {
        bool willSpeakAgain = true;
        public override void Process(CommandArgs args)
        {
            var castedArgs = (HearCommandArgs)args;
            if (willSpeakAgain)
            {
                World.Instance.Push(new CommandData() { Invoker = args.Invoker, Command = new SayCommand(), Args = new string[] { "Oi mate!", castedArgs.From.Title } });
                willSpeakAgain = false;
            }
            else
                World.Instance.Push(new CommandData() { Invoker = args.Invoker, Command = new SayCommand(), Args = new string[] { "Leave me alone!", castedArgs.From.Title } });
        }
    }
}
