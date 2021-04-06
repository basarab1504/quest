using System;

namespace quest
{
    class HoboIdleBehavior : AliveBehavior
    {
        public override void Process(CommandArgs args)
        {
            if (new Random().NextDouble() > 0.5f)
            {
                World.Instance.Push(new CommandData() { Invoker = args.Invoker, Command = new SayCommand(), Args = new string[] { "*sigh* Damn it's cold today.", "-" } });
            }
        }
    }
}
