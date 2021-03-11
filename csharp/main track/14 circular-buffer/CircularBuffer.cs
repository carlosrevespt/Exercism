using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private Queue<T> buffer;
    private int capacity;
    
    public CircularBuffer(int capacity) {
        buffer = new Queue<T>(capacity);
        this.capacity = capacity;
    }

    public T Read() => buffer.Dequeue();

    public void Write(T value) {
        if (IsFull()) throw new InvalidOperationException();
        buffer.Enqueue(value);
    }

    public void Overwrite(T value) {
        if (IsFull()) Read();
        Write(value);
    }

    public void Clear() => buffer.Clear();

    private bool IsFull() => buffer.Count == capacity;
}