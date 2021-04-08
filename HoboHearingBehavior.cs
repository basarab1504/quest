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
                World.Instance.Push(new CommandData()
                {
                    Command = new SayCommand(),
                    Args = new CommandArgs() { Invoker = castedArgs.Invoker, ToInteract = castedArgs.From, Message = "Hello there!" }
                });
                willSpeakAgain = false;
            }
            else
                World.Instance.Push(new CommandData()
                {
                    Command = new SayCommand(),
                    Args = new CommandArgs() { Invoker = castedArgs.Invoker, ToInteract = castedArgs.From, Message = "Get off, punk." }
                });
        }
    }
}
