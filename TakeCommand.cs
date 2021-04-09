// namespace quest
// {
//     class TakeCommand : ICommand
//     {
//         public void Execute(CommandArgs args)
//         {
//             if (args.Invoker.TryGet<InventoryBehavior>(out InventoryBehavior invokerBehavior))
//             {
//                 invokerBehavior.Process(new TakeCommandArgs() { Invoker = args.Invoker });
//             }
//         }
//     }

//     class TakeCommandArgs : CommandArgs
//     {
//         public GameObject[] Items { get; set; }
//     }

// }
