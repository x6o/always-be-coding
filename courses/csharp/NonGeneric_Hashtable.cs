static class Program
{
    static void Main(string[] args)
    {
        // Creating
        Hashtable hash = new Hashtable();

        // Adding (key and value are of type object)
        Console.WriteLine("------------ Adding to Hash ------------");

        hash.Add("Microsoft", "USA");
        hash.Add("Sony", "Japan");
        hash.Add("IKEA", "Sweden");
        hash.Add("Mercedes", "Germany");

        // Displaying
        foreach (DictionaryEntry item in hash)
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }

        // Count
        Console.WriteLine("------------ Count elements ------------");

        Console.WriteLine("Count is {0}", hash.Count);

        // Remove
        Console.WriteLine("------------ Removing IKEA from Hash ------------");

        hash.Remove("IKEA");

        foreach (DictionaryEntry item in hash)
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }

        // Contains
        Console.WriteLine("------------ Contains Sony condition ------------");
        // Also hash.ContainsValue() and hash.ContainsKey()
        Console.WriteLine(hash.Contains("Sony"));

        // Copy to ArrayList
        Console.WriteLine("------------ Copy to ArrayList ------------");

        ArrayList HashKeys = new ArrayList(hash.Keys);
        foreach (var item in HashKeys)
        {
            Console.WriteLine(item);
        }
    }
}
