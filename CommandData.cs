namespace quest
{
    struct CommandData
    {
        public GameObject Invoker { get; set; }
        public ICommand Command { get; set; }
        public string FullCommand { get; set; }
    }
}
