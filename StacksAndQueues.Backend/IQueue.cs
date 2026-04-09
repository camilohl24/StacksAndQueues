namespace StacksAndQueues.Backend
{
    internal interface IQueue<T>
    {
        T Dequeue();
        void Enqueue(T item);
    }
}