using System;
using System.Collections.Generic;

namespace quest
{
    class GameObject
    {
        private Dictionary<Type, IBehavior> behaviors = new Dictionary<Type, IBehavior>();

        public string Title { get; set; }
        public string Description { get; set; }

        public bool TryAdd<T>(IBehavior behavior) where T : IBehavior
        {
            return behaviors.TryAdd(typeof(T), behavior);
        }

        public bool TryGet<T>(out T behavior) where T : IBehavior
        {
            behavior = default(T);
            if (behaviors.ContainsKey(typeof(T)))
            {
                behavior = (T)behaviors[typeof(T)];
                return true;
            }
            return false;
        }
    }
}
