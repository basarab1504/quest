namespace quest
{
    abstract class TickBehavior : IProcessableBehavior
    {
        public abstract void Process(CommandArgs args);
    }
}
