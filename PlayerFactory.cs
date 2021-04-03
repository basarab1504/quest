namespace quest
{
    class PlayerFactory : Factory<Character>
    {
        protected override Character MakeInternal()
        {
            Character character = new Character();
            character.Title = "Mary Sue";
            character.Description = "Last hope?";
            character.behaviors.Add(typeof(LookBehavior), new LookBehavior());
            return character;
        }
    }
}
