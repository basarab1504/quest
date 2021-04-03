namespace quest
{
    class SayCommand : ICommand
    {
        public void Execute(Character character, string[] args)
        {
            if (character.behaviors.ContainsKey(typeof(OnSayBehavior)))
            {
                if (World.Instance.TryFindCharacter(args[2], out Character to))
                {
                    System.Console.WriteLine($"You say {args[1]} to {to.Title}");
                }
                else
                {
                    System.Console.WriteLine("You can't speak.");
                }
            }
        }
    }
}
