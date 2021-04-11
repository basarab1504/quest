namespace quest
{
    interface IProcessableBehavior : IBehavior
    {
        void Process(CommandArgs args);
    }
}
