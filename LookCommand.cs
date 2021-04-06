namespace quest
{
    class LookCommand : ICommand
    {
        public void Execute(GameObject invoker, string command)
        {
            if (invoker.TryGet<SightBehavior>(out SightBehavior behavior))
            {
                var splitted = command.Split();
                string lookAt = splitted[1];

                if (World.Instance.TryGet(lookAt, out GameObject gameObject))
                    behavior.Process(new LookCommandArgs() { Invoker = invoker, LookAt = gameObject });
                else
                    System.Console.WriteLine("You look around but don't find what you are looking for.");
            }
            else
                System.Console.WriteLine("You can't see.");
        }
    }

    class LookCommandArgs : CommandArgs
    {
        public GameObject LookAt { get; set; }
    }
}