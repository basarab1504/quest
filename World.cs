using System;
using System.Linq;
using System.Collections.Generic;

namespace quest
{
    class World
    {
        private List<IBehavior> behaviors = new List<IBehavior>();
        private List<GameObject> gameObjects = new List<GameObject>();
        private List<GameObject> alive = new List<GameObject>();
        private Queue<CommandData> commands = new Queue<CommandData>();
        private CommandParser parser;

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

        public World()
        {
            parser = new CommandParser();
            parser.TryAddCommand("look", new LookCommand());
        }

        public void Update()
        {
            foreach (var item in alive)
            {
                item.TryGet<PlayerBehavior>(out PlayerBehavior player);
                player.Process(new CommandArgs()
                {
                    Invoker = item
                });
            }
            while (commands.Count > 0)
            {
                var command = commands.Dequeue();
                command.Command.Execute(command.Invoker, command.FullCommand);
            }
        }

        public void Parse(GameObject invoker, string input)
        {
            if (parser.TryParse(invoker, input, out ICommand command))
                Push(new CommandData() { Invoker = invoker, Command = command, FullCommand = input });
        }

        public void Push(CommandData data)
        {
            commands.Enqueue(data);
        }

        public bool TryAdd<T>(GameObject gameObject) where T : IBehavior, new()
        {
            if (!gameObject.TryGet<T>(out T behavior))
            {
                behavior = new T();
                behaviors.Add(behavior);
                //Ужасно
                if (behavior is PlayerBehavior)
                    alive.Add(gameObject);
            }
            return gameObject.TryAdd<T>(behavior);
        }

        public T Create<T>() where T : GameObject, new()
        {
            var obj = new T();
            gameObjects.Add(obj);
            return obj;
        }

        public bool TryGet<T>(string name, out T gameObject) where T : GameObject
        {
            gameObject = (T)gameObjects.Find(x => x.Title == name);
            return true;
        }
    }
}
