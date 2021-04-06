using System;

namespace quest
{
    class PlayerBehavior : TickBehavior
    {
        public override void Process(CommandArgs args)
        {
            string input = Console.ReadLine();
            World.Instance.Parse(args.Invoker, input);
        }
    }
}
