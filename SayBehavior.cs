namespace quest
{
    class SayBehavior : IBehavior
    {
        public void Process(CommandArgs args)
        {
            if (args.ToInteract == null)
                System.Console.WriteLine($"{args.Invoker.Title} said \"{args.Message}\"");
            else
                System.Console.WriteLine($"{args.Invoker.Title} said \"{args.Message}\" to {args.ToInteract.Title}");
        }
    }
}
