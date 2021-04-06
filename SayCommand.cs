namespace quest
{
    class SayCommand : ICommand
    {
        public void Execute(GameObject invoker, string[] args)
        {
            if (invoker.TryGet<SayBehavior>(out SayBehavior behavior))
            {
                string speakTo = args[1];

                World.Instance.TryGet(speakTo, out GameObject gameObject);
                behavior.Process(new SayCommandArgs() { Invoker = invoker, SayTo = gameObject, Message = args[0] });

                if (gameObject != null && gameObject.TryGet<HearingBehavior>(out HearingBehavior hearingBehavior))
                    hearingBehavior.Process(new HearCommandArgs() { Invoker = gameObject, From = invoker, Text = args[0] });
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
