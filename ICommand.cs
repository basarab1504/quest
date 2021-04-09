namespace quest
{
    interface ICommand
    {
        CommandArgs Parse(string fullCommand);
        void Execute(CommandArgs args);
    }
}
