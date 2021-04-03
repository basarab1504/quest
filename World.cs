using System.Collections.Generic;

namespace quest
{
    class World
    {
        public List<Character> Characters { get; set; } = new List<Character>();
        public Player Player { get; set; }

        public void Init()
        {

        }

        public void Update()
        {
            foreach (var item in Characters)
                Process(item);
            Player.Poll();
        }

        private void Process(Character c)
        {
            if (c.Actions.Count == 0)
                return;

            string command = c.Actions.Dequeue();

            switch (command)
            {
                case "look":
                    {
                        System.Console.WriteLine(c.Room.Description);
                        break;
                    }
            }
        }
    }
}
