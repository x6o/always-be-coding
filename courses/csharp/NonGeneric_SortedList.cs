static class Program
{
    static void Main(string[] args)
    {
        // Creating
        SortedList sortedList = new SortedList();

        // Adding
        Console.WriteLine("------------ Adding to SortedList ------------");

        sortedList.Add(1, "Jan");
        sortedList.Add(2, "Feb");
        sortedList.Add(3, "Mar");
        sortedList.Add(4, "Apr");
        sortedList.Add(5, "May");

        // Displaying
        Console.WriteLine("------------ Displaying Hash with foreach loop ------------");

        foreach (DictionaryEntry item in sortedList)
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }

        Console.WriteLine("------------ Displaying Hash with for loop ------------");
        for (int i = 0; i < sortedList.Count; i++)
        {
            Console.WriteLine(sortedList.GetKey(i) + ": " + sortedList.GetByIndex(i));
        }

        // Index (Will return the value at that index)
        Console.WriteLine("------------ Accessing SortedList by index ------------");

        Console.WriteLine(sortedList[2].ToString());

        // Count
        Console.WriteLine("Number of items in sortedList: " + sortedList.Count);

        // Remove
        sortedList.Remove(1); // Remove by key 
        // also: sortedList.RemoveAt(index);

        // Contains
        Console.WriteLine("------------ SortedList contains method (FOO) ------------");

        Console.WriteLine(sortedList.ContainsValue("FOO"));

        // Copy to ArrayList
        Console.WriteLine("------------ Copy SortedList to ArrayList ------------");

        ArrayList arrayValues = new ArrayList(sortedList.Values);

        foreach (var item in arrayValues)
        {
            Console.WriteLine(item);
        }
    }
}
