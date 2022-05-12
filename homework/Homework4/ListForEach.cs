using System;
public class Node<T>
{
    public Node<T> next { get; set; }
    public T Data { get; set; }

    public Node(T t)
    {
        next = null;
        Data = t;
    }
}

public class GenericList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public GenericList()
    {
        head = tail = null;

    }

    public Node<T> Head
    {
        get => head;

    }

    public static void ForEach<T>(GenericList<T> genericList, Action<T> action)
    {
        for (Node<T> head = genericList.head; head != null; head = head.next)
        {
            action(head.Data);
        }
    }

    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
        if (tail == null)
        {
            head = tail = n;
        }
        else
        {
            tail.next = n;
            tail = n;
        }
    }

    
        

       


    }

public class GenericListTest
{
    static void Main(String[] args)
    {

        GenericList<int> intlist = new GenericList<int>();
        for (int x = 0; x < 10; x++)
        {
            intlist.Add(x);
        }

        int max = intlist.Head.Data;
        int min = intlist.Head.Data;
        int sum = 0;
        GenericList<int>.ForEach(intlist, i =>
        {
            max = max > i ? max : i;
            min = min < i ? min : i;
            sum += i;
        });

        Console.WriteLine("max: " + max + " min:" + min + " sum:" + sum);
    }
}


