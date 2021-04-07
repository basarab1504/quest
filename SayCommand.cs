using System.Text.RegularExpressions;

namespace quest
{
    class SayCommand : ICommand
    {
        public void Execute(GameObject invoker, string fullcommand)
        {
            if (invoker.TryGet<SayBehavior>(out SayBehavior behavior))
            {
                var splitted = fullcommand.Split();

                if (splitted.Length > 2)
                {
                    string speakTo = splitted[splitted.Length - 1];

                    World.Instance.TryGet(speakTo, out GameObject gameObject);

                    if (gameObject != null)
                    {
                        if (gameObject.TryGet<HearingBehavior>(out HearingBehavior hearingBehavior))
                            hearingBehavior.Process(new HearCommandArgs() { Invoker = gameObject, From = invoker, Text = string.Join(' ', splitted[1..(splitted.Length - 2)]) });
                        behavior.Process(new SayCommandArgs() { Invoker = invoker, SayTo = gameObject, Message = string.Join(' ', splitted[1..(splitted.Length - 1)]) });
                    }
                    else
                        behavior.Process(new SayCommandArgs() { Invoker = invoker, SayTo = gameObject, Message = string.Join(' ', splitted[1..(splitted.Length)]) });
                }
                else
                {
                    behavior.Process(new SayCommandArgs() { Invoker = invoker, SayTo = null, Message = string.Join(' ', splitted[1..(splitted.Length)]) });
                }

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
