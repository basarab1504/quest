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
            World.Instance.TryAdd<PlayerHearingBehavior>(player);
            World.Instance.TryAdd<SayBehavior>(player);
            World.Instance.TryAdd<InventoryBehavior>(player);
            player.Title = "Ivan";
            player.Description = "Ugly traveler";

            var amulet = World.Instance.Create<GameObject>();
            amulet.Title = "Amulet";
            amulet.Description = "Dirty";

            var hobo = World.Instance.Create<GameObject>();
            World.Instance.TryAdd<SayBehavior>(hobo);
            World.Instance.TryAdd<HoboIdleBehavior>(hobo);
            World.Instance.TryAdd<HoboHearingBehavior>(hobo);
            World.Instance.TryAdd<InventoryBehavior>(hobo);
            hobo.Title = "Hobo";
            hobo.Description = "Handsome homeless man";

            hobo.TryGet<InventoryBehavior>(out InventoryBehavior behavior);
            behavior.Add(amulet);
            behavior.Gold = 100;

            World.Instance.Update();
            World.Instance.Update();
            World.Instance.Update();
            World.Instance.Update();
        }
    }
}
