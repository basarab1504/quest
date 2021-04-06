using System;

namespace quest
{
    class PlayerBehavior : IBehavior
    {
        public void Process(CommandArgs args)
        {
            string input = Console.ReadLine();
            World.Instance.Parse(args.Invoker, input);
        }
    }
}
