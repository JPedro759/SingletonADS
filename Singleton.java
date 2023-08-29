public class HelloWorld {
    public static void main(String[] args) {
        Queue queue1 = Queue.getInstance();
        Queue queue2 = Queue.getInstance();

        if (queue1 == queue2)
            System.out.println("Singleton works!");
        else
            System.out.println("Singleton failed!");
    }
}

class Queue {
    private static Queue _instance;

    private Queue() {
        // Construtor privado
    }

    public static Queue getInstance() {
        if (_instance == null)
            _instance = new Queue();

        return _instance;
    }

    public void printDocument() {
        // Implementação da função
    }

    public void removeDocument() {
        // Implementação da função
    }

    public void removeAllDocument() {
        // Implementação da função
    }
}
