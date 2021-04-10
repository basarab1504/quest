namespace quest
{
    interface IBehavior
    {

    }

    interface IProcessableBehavior : IBehavior
    {
        void Process(CommandArgs args);
    }
}
