using System;
using System.Collections.Generic;

namespace quest
{
    class Room
    {
        public string Title { get; set; }
        public string Description { get; set; }

        private List<GameObject> objects = new List<GameObject>();

        public void Add(GameObject gameObject)
        {
            gameObject.Room = this;
            objects.Add(gameObject);
        }

        public void Remove(GameObject gameObject)
        {
            objects.Add(gameObject);
        }

        public bool Contains(GameObject gameObject)
        {
            return objects.Contains(gameObject);
        }

        public IReadOnlyList<GameObject> All => objects;

        public IReadOnlyList<GameObject> FindAll(Predicate<GameObject> predicate)
        {
            return objects.FindAll(predicate);
        }
    }
}
