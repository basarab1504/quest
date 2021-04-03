namespace quest
{
    abstract class Factory<T> where T : GameObject
    {
        public T Make()
        {
            var obj = MakeInternal();
            World.Instance.Setup<T>(obj);
            return obj;
        }

        protected abstract T MakeInternal();
    }
}
