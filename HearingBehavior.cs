namespace quest
{
    abstract class HearingBehavior : IBehavior
    {
        public abstract void Process(CommandArgs args);
    }
}
