namespace quest
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Character() { Name = "Игрок" };
            var npc = new Character() { Name = "Хобо" };
            var room = new Room() { Title = "Дорога", Description = "Пыльная дорога, край которой не видно на горизонте" };
            player.Room = room;
            npc.Room = room;
            // room.RoomOjbects.Add()
            World world = new World();
            Player player1 = new Player();
            player1.playableCharacter = player;
            world.Player = player1;
            world.Characters.Add(player);
            world.Characters.Add(npc);
            world.Init();
            world.Update();
            world.Update();
            world.Update();
        }
    }
}
