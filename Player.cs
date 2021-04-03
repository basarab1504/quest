namespace quest
{
    class Player
    {
        public Character playableCharacter { get; set; }

        public void Poll()
        {
            playableCharacter.Actions.Enqueue(System.Console.ReadLine());
        }
    }
}
