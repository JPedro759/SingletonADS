using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Queue queue1 = Queue.GetInstance();
        Queue queue2 = Queue.GetInstance();

        Console.WriteLine((queue1 == queue2) ? "Singleton works!" : "Singleton failed!");
    }
}

public class Queue
{
    private static Queue _instance;

    private Queue()
    {
        // Construtor privado
    }

    public static Queue GetInstance()
    {
        if (_instance == null)
            _instance = new Queue();

        return _instance;
    }

    public void PrintDocument()
    {
        // Implementação da função
    }

    public void RemoveDocument()
    {
        // Implementação da função
    }

    public void RemoveAllDocument()
    {
        // Implementação da função
    }
}

