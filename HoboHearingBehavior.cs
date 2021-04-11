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

                if (castedArgs.Invoker.TryGet<InventoryBehavior>(out InventoryBehavior behavior))
                {
                    if (behavior.TryFind(x => x.Title == "Amulet", out GameObject item))
                    {
                        World.Instance.Push(new CommandData()
                        {
                            Command = new GiveCommand(),
                            Args = new GiveCommandArgs() { Invoker = castedArgs.Invoker, GiveTo = castedArgs.From, Items = new GameObject[] { item } }
                        });
                    }
                }

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
