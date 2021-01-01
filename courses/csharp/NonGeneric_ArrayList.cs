static class Program
{
    static void PrintArray(ref ArrayList arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    static void Main(string[] args)
    {
        // Creating
        ArrayList array = new ArrayList();

        // Adding
        Console.WriteLine("------------ Adding elements ------------");

        // Adds at the end of the array
        array.Add("First");
        array.Add("Second");
        array.Add("James");
        array.Add("David");

        PrintArray(ref array);

        // Add to array in a specific index
        Console.WriteLine("------------ After insertion ------------");

        array.Insert(2, "Third");

        PrintArray(ref array);

        // Index accessing, like a array
        Console.WriteLine("------------ Index accessing ------------");

        Console.WriteLine(array[0].ToString());

        // Count
        Console.WriteLine("------------ Count Elements ------------");

        Console.WriteLine("Array has {0} elements.", array.Count);

        // Sorting
        Console.WriteLine("------------ Sorting Array ------------");

        // If elements of different type comparison will throw exception.
        array.Sort();

        PrintArray(ref array);

        // Reversing
        Console.WriteLine("------------ Reversing Array ------------");

        array.Reverse();

        PrintArray(ref array);

        // Removing elements from the array
        Console.WriteLine("------------ Removing James from array ------------");

        // array.RemoveAt() to remove at specific index
        // array.RemoveRange() to remove at a range of indexes
        array.Remove("James");

        PrintArray(ref array);

        // Removing ALL elements from array
        // array.Clear();

        // Contains
        Console.WriteLine("------------ Checking if array contains \"James\" item ------------");

        Console.WriteLine(array.Contains("James"));

        // GetRange
        Console.WriteLine("------------ GetRange ------------");

        ArrayList names = new ArrayList();

        //Returns a subset of elements between two indices.
        names = array.GetRange(0, 2);

        PrintArray(ref names);
    }
}
