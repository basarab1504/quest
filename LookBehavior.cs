namespace quest
{
    //задача поведения - обозначить реакцию по аргументам
    class LookBehavior : CharacterBehavior
    {
        public override void Execute()
        {
            System.Console.WriteLine($"{Character.Room.Title} - {Character.Room.Description}");
        }
    }
}
