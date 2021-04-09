// namespace quest
// {

//     class GiveCommand : ICommand
//     {
//         public void Execute(CommandArgs args)
//         {
//             var castedArgs = (GiveCommandArgs)args;
//             if (args.Invoker.TryGet<InventoryBehavior>(out InventoryBehavior invokerBehavior)
//                 && args.ToInteract.TryGet<InventoryBehavior>(out InventoryBehavior toBehavior))
//             {
//                 toBehavior.Process(new GiveCommandArgs() { Invoker = castedArgs.Invoker, ToInteract = castedArgs.ToInteract, Items = castedArgs.Items });
//             }
//         }

//         public CommandArgs Parse(string fullCommand)
//         {
//             var splitted = fullCommand.Split();

//             World.Instance.TryGet<GameObject>(splitted[splitted.Length - 1], out GameObject gameObject);

//             return new LookCommandArgs() { LookAt = gameObject };
//         }
//     }

//     class GiveCommandArgs : CommandArgs
//     {
//         public GameObject[] Items { get; set; }
//     }
// }
