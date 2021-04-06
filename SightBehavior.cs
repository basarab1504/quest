namespace quest
{
    class SightBehavior : IBehavior
    {
        public void Process(CommandArgs args)
        {
            var castedArgs = (LookCommandArgs)args;
            System.Console.WriteLine(castedArgs.LookAt.Description);
        }
    }
}
