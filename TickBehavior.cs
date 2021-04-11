namespace quest
{
    abstract class AliveBehavior : IProcessableBehavior
    {
        public abstract void Process(CommandArgs args);
    }
}
