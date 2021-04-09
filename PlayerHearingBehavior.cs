namespace quest
{
    class PlayerHearingBehavior : HearingBehavior
    {
        public override void Process(CommandArgs args)
        {
            var castedArgs = (HearCommandArgs)args;
            System.Console.WriteLine($"{castedArgs.From.Title} said \"{castedArgs.Message}\" to {castedArgs.Invoker.Title}");
        }
    }
}
