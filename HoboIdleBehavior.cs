using System;

namespace quest
{
    class HoboIdleBehavior : TickBehavior
    {
        public override void Process(CommandArgs args)
        {
            World.Instance.Push(new CommandData()
            {
                Command = new SayCommand(),
                Args = new SayCommandArgs() { Invoker = args.Invoker, Message = "Damn it's cold. *sigh*" }
            });
        }
    }
}
