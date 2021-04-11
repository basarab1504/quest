namespace quest
{
    class TransferMoneyCommand : ICommand
    {
        public string Pattern => "*command* *amount* *reciever*";

        public void Execute(CommandArgs args)
        {
            var castedArgs = (TransferMoneyCommandArgs)args;

            if (castedArgs.Invoker.TryGet<InventoryBehavior>(out InventoryBehavior behavior)
            && castedArgs.TransferTo.TryGet<InventoryBehavior>(out InventoryBehavior behavior1))
            {
                if (behavior.Gold >= castedArgs.Amount)
                {
                    behavior.Gold -= castedArgs.Amount;
                    behavior1.Gold += castedArgs.Amount;
                    System.Console.WriteLine($"{castedArgs.Invoker.Title} gave {castedArgs.Amount} gold to {castedArgs.TransferTo.Title}");
                }
                else
                {
                    System.Console.WriteLine($"{castedArgs.Invoker.Title} don't have such amount of gold");
                }
            }
            else
            {
                System.Console.WriteLine($"{castedArgs.Invoker.Title} can't transfer money to {castedArgs.TransferTo.Title}");
            }
        }

        public CommandArgs Parse(string fullCommand)
        {
            var splitted = fullCommand.Split();

            World.Instance.TryGet<GameObject>(splitted[2], out GameObject gameObject);
            int.TryParse(splitted[1], out int amount);

            return new TransferMoneyCommandArgs()
            {
                TransferTo = gameObject,
                Amount = amount
            };
        }
    }

    class TransferMoneyCommandArgs : CommandArgs
    {
        public GameObject TransferTo { get; set; }
        public int Amount { get; set; }
    }
}
