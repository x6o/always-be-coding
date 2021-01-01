static class Program
{
    static void Main(string[] args)
    {
        // A Stack represents a last-in first-out (LIFO) collection of objects.

        // Creating
        Stack stack = new Stack();

        // Adding 
        stack.Push("David");
        stack.Push("Josh");
        stack.Push("Maria");
        stack.Push("Paul");

        // Removing
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }
}
