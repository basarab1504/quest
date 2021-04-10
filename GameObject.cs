using System;
using System.Linq;
using System.Collections.Generic;

namespace quest
{
    class GameObject
    {
        private List<IBehavior> behaviors = new List<IBehavior>();

        public string Title { get; set; }
        public string Description { get; set; }

        public bool TryAdd<T>(T behavior) where T : IBehavior
        {
            behaviors.Add(behavior);
            return true;
        }

        public bool TryGet<T>(out T behavior) where T : IBehavior
        {
            behavior = default(T);
            if (behaviors.OfType<T>().Count() > 0)
            {
                behavior = (T)behaviors.First(x => x is T);
                return true;
            }
            return false;
        }
    }
}
