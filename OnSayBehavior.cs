using System;

namespace quest
{
    class OnSayBehavior : CharacterBehavior
    {
        public Action Action;
        public override void Execute()
        {
            Action();
        }
    }
}
