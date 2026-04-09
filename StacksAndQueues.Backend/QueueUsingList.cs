using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Backend;

public class QueueUsingList<T> : IQueue<T>
{
    private List<T> _queue = [];

    public T Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is Empty");
        }
        var item = _queue[0];
        _queue.Remove(item);
        return item;
    }

    public void Enqueue(T item)
    {
        _queue.Add(item);
    }
}