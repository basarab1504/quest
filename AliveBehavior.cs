namespace quest
{
    abstract class AliveBehavior : IBehavior
    {
        public abstract void Process(CommandArgs args);
    }
}
