namespace quest
{
    class SayCommand : ICommand
    {
        public void Execute(GameObject invoker, string command)
        {
            if (invoker.TryGet<SayBehavior>(out SayBehavior behavior))
            {
                var splitted = command.Split();
                string speakTo = splitted[2];

                if (World.Instance.TryGet(speakTo, out GameObject gameObject))
                {
                    behavior.Process(new SayCommandArgs() { Invoker = invoker, SayTo = gameObject, Message = splitted[1] });
                }
                else
                    System.Console.WriteLine($"{invoker.Title} found no one to hear your words.");
            }
            else
                System.Console.WriteLine($"{invoker.Title} can't speak.");
        }
    }

    class SayCommandArgs : CommandArgs
    {
        public GameObject SayTo { get; set; }
        public string Message { get; set; }
    }
}
