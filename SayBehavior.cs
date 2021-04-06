namespace quest
{
    class SayBehavior : IBehavior
    {
        public void Process(CommandArgs args)
        {
            var castedArgs = (SayCommandArgs)args;
            if (castedArgs.SayTo == null)
                System.Console.WriteLine($"{args.Invoker.Title} said \"{castedArgs.Message}\" to the world");
            else
                System.Console.WriteLine($"{args.Invoker.Title} said \"{castedArgs.Message}\" to {castedArgs.SayTo.Title}");
        }
    }
}
