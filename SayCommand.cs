namespace quest
{
    class SayCommand : ICommand
    {
        public void Execute(CommandArgs args)
        {
            var castedArgs = (SayCommandArgs)args;
            if (args.Invoker.TryGet<SayBehavior>(out SayBehavior behavior))
                behavior.Process(args);
            else
                System.Console.WriteLine($"{args.Invoker.Title} can't speak.");
        }

        public CommandArgs Parse(string fullCommand)
        {
            var splitted = fullCommand.Split();

            World.Instance.TryGet<GameObject>(splitted[splitted.Length - 1], out GameObject gameObject);

            return new SayCommandArgs() { SpeakWith = gameObject, Message = string.Join(' ', splitted[1..(splitted.Length - 1)]) };
        }
    }

    class SayCommandArgs : CommandArgs
    {
        public GameObject SpeakWith { get; set; }
        public string Message { get; set; }
    }
}
