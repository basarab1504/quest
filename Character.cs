using System.Collections.Generic;

namespace quest
{
    class Character
    {
        public string Name { get; set; }
        public Room Room { get; set; }
        private List<string> inventory;

        public Queue<string> Actions { get; } = new Queue<string>();

        public void Put(string obj)
        {
            inventory.Add(obj);
        }

        public string Pull(string obj)
        {
            return inventory.Find(x => x == obj) ?? "";
        }
    }
}
