static class Program
{
    static void Main(string[] args)
    {
        // A Queue represents a first-in first-out (FIFO) collection of objects.

        // Creating
        Queue queue = new Queue();

        // Adding
        queue.Enqueue("John");
        queue.Enqueue("Tom");
        queue.Enqueue("David");

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        // Removing
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
    }
}
