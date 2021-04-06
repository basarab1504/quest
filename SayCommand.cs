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

                World.Instance.TryGet(speakTo, out GameObject gameObject);
                behavior.Process(new SayCommandArgs() { Invoker = invoker, SayTo = gameObject, Message = splitted[1] });

                if (gameObject != null && gameObject.TryGet<HearingBehavior>(out HearingBehavior hearingBehavior))
                    hearingBehavior.Process(new HearCommandArgs() { Invoker = gameObject, From = invoker, Text = splitted[1] });

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
