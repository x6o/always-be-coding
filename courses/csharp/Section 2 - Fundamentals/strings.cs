static void Main(string[] args)
{
    string movieName = "Lord of the rings";

    // Indexes
    Console.WriteLine(movieName[0]); // Will print "L"
    //Console.WriteLine(movieName[999]); // Index out of bounds error
    Console.WriteLine(movieName.IndexOf('f')); // Will print 6, only first occurence
    Console.WriteLine(movieName.LastIndexOf('o')); // Will print 5, only last occurence

    // Trim
    movieName = "    Lord of the rings    ";
    Console.WriteLine(movieName.Trim()); // Will print "Lord of the rings" (Removes trailing and leading whitespace)

    // Upper Case
    movieName = "Lord of the rings";
    Console.WriteLine(movieName.ToUpper()); // Will print "LORD OF THE RINGS"

    // Lower Case
    movieName = "Lord of The RINGS";
    Console.WriteLine(movieName.ToLower()); // Will print "lord of the rings"

    // Length
    Console.WriteLine(movieName.Length); // Will print 17

    // Replace (returns a new string)
    Console.WriteLine(movieName.Replace('o', 'O')); // Will print "LOrd Of The RINGS"

    // Substring:
    // - Substring(int StartIndex)
    // - Substring(int StrartIndex, int Length)

    Console.WriteLine(movieName.Substring(2)); // Will print "rd of The RINGS"
    Console.WriteLine(movieName.Substring(2, 2)); // Will print "rd"

    // Remove: Will return a new string where the characters from StartIndex onward are deleted.
    // - Remove(int StartIndex)
    // - Remove(int StartIndex, int count) -> Count arg is how many chars to remove

    Console.WriteLine(movieName.Remove(2)); // Will return "Lo"
    Console.WriteLine(movieName.Remove(2, 6)); // Will return "LoThe RINGS"

    // Insert (returns a new string)
    Console.WriteLine(movieName.Insert(0, "Name: ")); // Will return "Name: Lord of The RINGS"

    // Escaping
    Console.WriteLine("\"All work and no play makes Jack a dull boy\"");
    Console.WriteLine("D:\\Movies");
    Console.WriteLine("\"All work and no play \t makes Jack a dull boy\""); // \t adds a tab

    // Interpolation
    string name = "Andrei";

    //Console.WriteLine("Welcome back " + name);
    //Console.WriteLine("Welcome back {0}", name);
    Console.WriteLine($"Welcome back again {name}");
}