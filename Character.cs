using System;
using System.Collections.Generic;

namespace quest
{
    class Character : GameObject
    {
        public Room Room { get; set; }
        public Dictionary<Type, IBehavior> behaviors = new Dictionary<Type, IBehavior>();
        public Queue<ICommand> Commands { get; set; }
    }
}
