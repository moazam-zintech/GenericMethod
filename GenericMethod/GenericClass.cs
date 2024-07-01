namespace GenericMethod
{
    internal class GenericClass<T>
    {
        List<T> ts = new();
        public void AddItem(T item)
        {
            ts.Add(item);
        }

        public void RemoveItem(T item)
        {
            ts.Remove(item);
        }
    }
}
