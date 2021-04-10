using System.Collections.Generic;

namespace quest
{
    class InventoryBehavior : IBehavior
    {
        private List<GameObject> items = new List<GameObject>();
        
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
