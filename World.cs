using System;
using System.Collections.Generic;

namespace quest
{
    class World
    {
        private static World instance;
        public static World Instance
        {
            get
            {
                if (instance == null)
                    instance = new World();
                return instance;
            }
        }

        List<Room> rooms = new List<Room>();
        List<Character> characters = new List<Character>();
        public Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();

        public void Update()
        {
            foreach (var item in characters)
                item.Commands.Dequeue();
        }

        public void Setup<T>(T obj) where T : GameObject
        {
            if (obj is Room)
                rooms.Add(obj as Room);
            else if (obj is Character)
                characters.Add(obj as Character);
        }

        public bool TryFindCharacter(string name, out Character character)
        {
            character = characters.Find(x => x.Title == name);
            return character == null;
        }
    }
}
