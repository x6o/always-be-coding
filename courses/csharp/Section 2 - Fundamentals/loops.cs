static void Main(string[] args)
{
    // Loops

    // Displays "C# rocks" 10 times, i incrementing from 1 to 10
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("{0}: C# rocks", i);
    }

    // Displays "C# rocks" 10 times, i incrementing from 1 to 10 
    // and 0 incrementing from 0 to 9 at the same iteration
    int v = 0;
    for (int i = 1; i <= 10; i++, v++)
    {
        Console.WriteLine("i:{0}|v:{1}: C# rocks", i, v);
    }

    // Displays "C# rocks" 10 times, i incrementing from 10 to 1
    for (int i = 10; i >= 1; i--)
    {
        Console.WriteLine("{0}: C# rocks", i);
    }

    // Displays "C# rocks" 4 times, i incrementing from 10 to 1, breaks when i=5;
    for (int i = 10; i >= 1; i--)
    {
        if (i == 5) break;
        Console.WriteLine("{0}: C# rocks", i);
    }

    // Increments from 1 to 10
    int x = 1;
    while (x <= 10)
    {
        //if (x == 5) break; //we can still break the loops
        Console.WriteLine("This is line no. {0}", x);
        x++;
    }

    // Increments from 1 to 10
    int p = 1;
    do
    {
        Console.WriteLine("This is line no. {0}", p);
        p++;
    } while (p <= 10);

    // Nested loops
    for (int z = 0; z <= 5; z++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write("0 ");
        }
        Console.WriteLine();
    }

    // Print all even numbers
    for (int i = 1; i < 20; i++)
    {
        if (i % 2 == 0) Console.WriteLine("Even: " + i);
    }

    // Triangle
    // Print a triangle like the following:
    //
    // 0
    // 00
    // 000
    // 0000
    // 00000
    // 000000
    // 0000000
    // 00000000
    // 000000000

    for (int j = 0; j < 15; j++)
    {
        for (int c = 1; c <= j; c++)
        {
            Console.Write("0 ");
        }
        Console.WriteLine();
    }
}