namespace quest
{
    interface ICommand
    {
        string Pattern { get; }
        CommandArgs Parse(string fullCommand);
        void Execute(CommandArgs args);
    }
}
