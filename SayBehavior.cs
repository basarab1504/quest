namespace quest
{
    class SayBehavior : IBehavior
    {
        public void Process(CommandArgs args)
        {
            var castedArgs = (SayCommandArgs)args;
            System.Console.WriteLine($"{args.Invoker.Title} said \"{castedArgs.Message}\" to {castedArgs.SayTo.Title}");
        }
    }
}
