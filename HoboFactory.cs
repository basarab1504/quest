namespace quest
{
    class HoboFactory : Factory<Character>
    {
        protected override Character MakeInternal()
        {
            Character character = new Character();
            character.Title = "Hobo";
            character.Description = "Strange man";
            OnSayBehavior onSayBehavior = new OnSayBehavior();
            onSayBehavior.Action = delegate
            {
                System.Console.WriteLine("Oh, it's you! Take this...");
                onSayBehavior.Action = delegate
                {
                    System.Console.WriteLine("Huh? Leave me alone, okay?");
                };
            };
            character.behaviors.Add(typeof(OnSayBehavior), onSayBehavior);
            return character;
        }
    }
}
