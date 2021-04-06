namespace quest
{
    abstract class TickBehavior : IBehavior
    {
        public abstract void Process(CommandArgs args);
    }
}
