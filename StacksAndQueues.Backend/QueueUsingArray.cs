using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Backend;

public class QueueUsingArray<T> : IQueue<T>
{
    private int _count;
    private int _front;
    private T[] _queue;
    private int _rear;

    public QueueUsingArray(int capacity)
    {
        _queue = new T[capacity];
        _front = 0;
        _rear = -1;
        _count = 0;
    }

    public T Dequeue()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        var item = _queue[_front];
        _front = (_front + 1) % _queue.Length;
        _count--;

        return item;
    }

    public void Enqueue(T item)
    {
        if (_count == _queue.Length)
        {
            throw new InvalidOperationException("Queue is Full");
        }

        _rear = (_rear + 1) % _queue.Length;
        _queue[_rear] = item;
        _count++;
    }
}