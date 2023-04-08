using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Queue queue1 = Queue.getInstance();
        Queue queue2 = Queue.getInstance();
        
            if (queue1 == queue2)
                Console.WriteLine("Singleton works!");
            else
                Console.WriteLine("Singleton failed!");   
    }
}

class Queue {
    
    private static Queue _instance;
    
    private Queue(){
        
    }
    
    public static Queue getInstance(){
        {
            if (_instance == null)
                _instance = new Queue();
            
            return _instance;
        }
    }
    
    public void printDocument(){} 
    
    public void removeDocument(){}
    
    public void removeAllDocument(){}
}
