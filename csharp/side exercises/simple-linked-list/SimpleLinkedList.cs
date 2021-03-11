using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    private Node<T> head;
    private Node<T> last;

    public SimpleLinkedList(T value)
    {
        Node<T> node = new Node<T>(value);
        head = last = node;
        head.next = last;
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public T Value 
    { 
        get
        {
            return last.myData;
        } 
    }

    public SimpleLinkedList<T> Next
    { 
        get
        {
            return new SimpleLinkedList<T>(last.myData);
        } 
    }

    public SimpleLinkedList<T> Add(T value)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}

internal class Node<T>
{
    internal T myData;
    internal Node<T> next;

    public Node (T data)
    {
        myData = data;
        next = null;
    }
}