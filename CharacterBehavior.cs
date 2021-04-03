namespace quest
{
    abstract class CharacterBehavior : IBehavior
    {
        protected Character Character { get; set; }
        public abstract void Execute();
    }
}
