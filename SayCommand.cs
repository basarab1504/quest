namespace quest
{
    class GiveCommand : ICommand
    {
        public void Execute(CommandArgs args)
        {
            if (args.Invoker.TryGet<InventoryBehavior>(out InventoryBehavior invokerBehavior)
                && args.Invoker.TryGet<InventoryBehavior>(out InventoryBehavior toBehavior)
                && World.Instance.TryGet<GameObject>(args.Message, out GameObject gameObject))
            {

            }
        }
    }

    class SayCommand : ICommand
    {
        public void Execute(CommandArgs args)
        {
            if (args.Invoker.TryGet<SayBehavior>(out SayBehavior behavior))
            {
                if (args.ToInteract != null && args.ToInteract.TryGet<HearingBehavior>(out HearingBehavior hearingBehavior))
                    hearingBehavior.Process(new HearCommandArgs() { Invoker = args.ToInteract, From = args.Invoker, Text = args.Message });
                behavior.Process(args);
            }
            else
                System.Console.WriteLine($"{args.Invoker.Title} can't speak.");
        }
    }
}
