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
                    Args = new SayCommandArgs() { Invoker = castedArgs.Invoker, SpeakWith = castedArgs.From, Message = "Hello there!" }
                });

                World.Instance.Parse(args.Invoker, $"give Amulet {castedArgs.From.Title}");

                World.Instance.Push(new CommandData()
                {
                    Command = new TransferMoneyCommand(),
                    Args = new TransferMoneyCommandArgs() { Invoker = castedArgs.Invoker, TransferTo = castedArgs.From, Amount = 100 }
                });

                willSpeakAgain = false;
            }
            else
            {
                World.Instance.Push(new CommandData()
                {
                    Command = new SayCommand(),
                    Args = new SayCommandArgs() { Invoker = castedArgs.Invoker, SpeakWith = castedArgs.From, Message = "Get off, punk." }
                });
            }
        }
    }
}
