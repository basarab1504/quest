namespace quest
{
    abstract class HearingBehavior : IProcessableBehavior
    {
        public abstract void Process(CommandArgs args);
    }
}
