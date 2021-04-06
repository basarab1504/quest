namespace quest
{
    class LookCommand : ICommand
    {
        public void Execute(GameObject invoker, string[] args)
        {
            if (invoker.TryGet<SightBehavior>(out SightBehavior behavior))
            {
                string lookAt = args[0];

                if (World.Instance.TryGet(lookAt, out GameObject gameObject))
                    behavior.Process(new LookCommandArgs() { Invoker = invoker, LookAt = gameObject });
                else
                    System.Console.WriteLine($"{invoker.Title} look around but can't notice anything");
            }
            else
                System.Console.WriteLine($"{invoker.Title} can't see.");
        }
    }

    class LookCommandArgs : CommandArgs
    {
        public GameObject LookAt { get; set; }
    }
}
