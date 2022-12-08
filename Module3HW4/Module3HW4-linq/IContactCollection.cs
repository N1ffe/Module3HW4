namespace Module3HW4_linq
{
    public interface IContactCollection<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        void Add(V item);
        void Delete(V item);
    }
}
