namespace quest
{
    class SayBehavior : IBehavior
    {
        public void Process(CommandArgs args)
        {
            var castedArgs = (SayCommandArgs)args;
            System.Console.WriteLine($"You said \"{castedArgs.Message}\" to {castedArgs.SayTo.Title}");
        }
    }
}
