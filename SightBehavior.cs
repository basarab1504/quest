namespace quest
{
    class SightBehavior : IProcessableBehavior
    {
        public void Process(CommandArgs args)
        {
            var castedArgs = (LookCommandArgs)args;
            System.Console.WriteLine($"{args.Invoker.Title} sees: {castedArgs.LookAt.Title} - {castedArgs.LookAt.Description}");
        }
    }
}
