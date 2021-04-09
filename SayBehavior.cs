namespace quest
{
    class SayBehavior : IBehavior
    {
        public void Process(CommandArgs args)
        {
            var castedArgs = (SayCommandArgs)args;
            if (castedArgs.SpeakWith != null)
            {
                World.Instance.Push(new CommandData() { Command = new HearCommand(), Args = new HearCommandArgs() { Invoker = castedArgs.SpeakWith, From = castedArgs.Invoker, Message = castedArgs.Message } });
                // System.Console.WriteLine($"{args.Invoker.Title} said \"{castedArgs.Message}\" to {castedArgs.SpeakWith.Title}");
            }
        }
    }
}
