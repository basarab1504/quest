using System.Collections.Generic;

namespace quest
{
    class GameObject
    {
        private List<IBehavior> behaviors = new List<IBehavior>();

        public string Title { get; set; }
        public string Description { get; set; }

        public Room Room { get; set; }

        public bool TryAdd<T>(T behavior) where T : IBehavior
        {
            behaviors.Add(behavior);
            return true;
        }

        public bool TryGet<T>(out T behavior) where T : IBehavior
        {
            behavior = default(T);
            foreach (var item in behaviors)
            {
                if (item is T)
                {
                    behavior = (T)item;
                    return true;
                }
            }
            return false;
        }
    }
}
