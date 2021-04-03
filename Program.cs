using System;

namespace quest
{
    class Program
    {
        static void Main(string[] args)
        {
            World.Instance.commands.Add("say", new SayCommand());
            World.Instance.commands.Add("look", new LookCommand());

            var room = new RoadRoomFactory().Make();
            var player = new PlayerFactory().Make();
            var hobo = new HoboFactory().Make();

            player.Room = room;
            hobo.Room = room;

            World.Instance.Update();
        }
    }
}
