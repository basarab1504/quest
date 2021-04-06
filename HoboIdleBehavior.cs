using System;

namespace quest
{
    class HoboIdleBehavior : IBehavior
    {
        public void Process(CommandArgs args)
        {
            if (new Random().NextDouble() > 0.5f)
            {
                System.Console.WriteLine("Oh I'm getting old. *sigh*");
            }
        }
    }
}
