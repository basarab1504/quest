namespace quest
{
    //задача команды - использовать инструменты Мира, чтобы создать корректные аргументы и проверить возможность выполнения команды
    class LookCommand : ICommand
    {
        public void Execute(Character character, string[] args)
        {
            if (character.behaviors.ContainsKey(typeof(LookBehavior)))
            {
                character.behaviors[typeof(LookBehavior)].Execute();
            }
            else
                System.Console.WriteLine("You can't see.");
        }
    }
}
