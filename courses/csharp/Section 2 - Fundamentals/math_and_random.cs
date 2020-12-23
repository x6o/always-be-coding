static void Main(string[] args)
{
    double x = 3.267;

    // Ceiling 
    // Returns the smallest integral value that is greater or equal than x
    Console.WriteLine("Ceiling: " + Math.Ceiling(x)); // Prints 4

    // Floor
    // Opposite of Ceiling method
    Console.WriteLine("Floor: " + Math.Floor(x)); // Prints 3

    // Round
    Console.WriteLine("Round: " + Math.Round(x)); // Prints 3
    Console.WriteLine("Round: " + Math.Round(x, 1)); // Prints 3.3
    Console.WriteLine("Round: " + Math.Round(x, 2)); // Prints 3.27

    // Truncate
    // Calculates the integral part of a floating-point number.
    Console.WriteLine("Truncate: " + Math.Truncate(x)); // Prints 3

    int y = 9, z = 4;

    // Max
    // Returns the larger of two ints (Always two, can't pass an array!)
    // TODO exercise: create an array extension method to get its max value.
    Console.WriteLine(Math.Max(y, z)); // Prints 9

    // Min
    // Self explanatory, opposite of Max
    Console.WriteLine("Min: " + Math.Min(y, z)); // Prints 4

    // sqrt
    Console.WriteLine("sqrt: " + Math.Sqrt(y)); // Prints 3

    // pow
    Console.WriteLine("pow: " + Math.Pow(2, 2));  // Prints 4

    // PI
    Console.WriteLine(Math.PI); // returns 3,141592653589793

    // Random numbers
    Random rand = new Random();
    int m = 0;

    // Generates a random int between 1 and 6
    m = rand.Next(1, 7);

    Console.WriteLine("Random int is {0}", m);

    double r = 0;

    // Generates a random double between 0 and 1
    r = rand.NextDouble();
    Console.WriteLine("Random double is {0}", r);
}