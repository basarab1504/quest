namespace quest
{
    class HearCommand : ICommand
    {
        public void Execute(GameObject invoker, string command)
        {
            if (invoker.TryGet<HearingBehavior>(out HearingBehavior behavior))
            {
                var splitted = command.Split();
                string listenTo = splitted[1];

                if (World.Instance.TryGet(listenTo, out GameObject gameObject))
                    System.Console.WriteLine("fff");
                    // behavior.Process(new HearCommandArgs() { Invoker = invoker, From = gameObject });
                else
                    System.Console.WriteLine("You look around but don't find what you are looking for.");
            }
            else
                System.Console.WriteLine("You can't hear.");
        }
    }

    class HearCommandArgs : CommandArgs
    {
        public string Text { get; set; }
    }
}
