namespace quest
{
    class WhereAmICommand : ICommand
    {
        public string Pattern => "";

        public void Execute(CommandArgs args)
        {
            if (args.Invoker.TryGet<SightBehavior>(out SightBehavior sightBehavior))
            {
                System.Console.WriteLine($"{args.Invoker.Title} location is {args.Invoker.Room.Title} - {args.Invoker.Room.Description}");
            }
        }

        public CommandArgs Parse(string fullCommand)
        {
            return new CommandArgs();
        }
    }
}

