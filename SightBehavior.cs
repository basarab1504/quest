namespace quest
{
    class SightBehavior : IBehavior
    {
        public void Process(CommandArgs args)
        {
            var castedArgs = (LookCommandArgs)args;
            System.Console.WriteLine($"{args.Invoker.Title} sees: {castedArgs.LookAt.Description}");
        }
    }
}
