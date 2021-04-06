using System;

namespace quest
{
    class HoboIdleBehavior : AliveBehavior
    {
        public override void Process(CommandArgs args)
        {
            if (new Random().NextDouble() > 0.5f)
            {
                System.Console.WriteLine("Oh I'm getting old. *sigh*");
            }
        }
    }
}
