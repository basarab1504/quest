namespace quest
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = World.Instance.Create<GameObject>();
            room.Title = "Road";
            room.Description = "Dustry old road";

            var player = World.Instance.Create<GameObject>();
            World.Instance.TryAdd<PlayerBehavior>(player);
            World.Instance.TryAdd<SightBehavior>(player);
            World.Instance.TryAdd<SayBehavior>(player);
            player.Title = "Ivan";
            player.Description = "Lazy";

            var hobo = World.Instance.Create<GameObject>();
            World.Instance.TryAdd<HoboIdleBehavior>(hobo);
            hobo.Title = "Hobo";
            hobo.Description = "Stinks";

            World.Instance.Update();
            World.Instance.Update();
            World.Instance.Update();
            World.Instance.Update();
        }
    }
}
