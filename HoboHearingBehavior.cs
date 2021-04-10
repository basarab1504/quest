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

                World.Instance.Parse(args.Invoker, $"give 100 gold {castedArgs.From.Title}");
                
                // World.Instance.Push(new CommandData()
                // {
                //     Command = new GiveCommand(),
                //     Args = new GiveCommandArgs() { Invoker = castedArgs.Invoker, GiveTo = castedArgs.From, Items =  }
                // });

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
