using System;
using System.Collections.Generic;

namespace quest
{
    class InventoryBehavior : IBehavior
    {
        private List<GameObject> items = new List<GameObject>();
        public int Gold { get; set; }

        public bool TryFind(Predicate<GameObject> predicate, out GameObject gameObject)
        {
            gameObject = items.Find(predicate);
            return gameObject != null;
        }
        
        public void Add(GameObject gameObject)
        {
            items.Add(gameObject);
        }

        public void Remove(GameObject gameObject)
        {
            items.Remove(gameObject);
        }
    }
}
