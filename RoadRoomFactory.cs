namespace quest
{

    class RoadRoomFactory : Factory<Room>
    {
        protected override Room MakeInternal()
        {
            Room room = new Room();
            room.Title = "Road";
            room.Description = "Dusty road";
            return room;
        }
    }
}
