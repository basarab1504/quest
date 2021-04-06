namespace quest
{
    interface ICommand
    {
        void Execute(GameObject invoker, string command);
    }
}
