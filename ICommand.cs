namespace quest
{
    interface ICommand
    {
        void Execute(Character character, string[] args);
    }
}