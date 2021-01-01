static class Program
{
    static void Main(string[] args)
    {
        // Represents a compact array of bit (0,1) values, which are represented as Booleans.

        // Creating
        bool[] boolArray = new bool[4];
        boolArray[0] = false;
        boolArray[1] = false;
        boolArray[2] = false;
        boolArray[3] = true;

        BitArray firstArray = new BitArray(4);
        BitArray secondArray = new BitArray(boolArray);

        // Setting value
        firstArray.Set(0, false);
        firstArray.Set(1, false);
        firstArray.Set(2, true);
        firstArray.Set(3, true);

        foreach (var item in secondArray)
        {
            Console.WriteLine(item);
        }

        // AND - OR - NOT
        Console.WriteLine("------------ AND operation ------------");

        BitArray resultAnd = new BitArray(4);
        resultAnd = firstArray.And(secondArray);

        foreach (var item in resultAnd)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("------------ OR operation ------------");

        BitArray resultOr = new BitArray(4);
        resultOr = firstArray.Or(secondArray);

        foreach (var item in resultOr)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("------------ NOT operation ------------");

        BitArray resultNot = new BitArray(4);
        resultNot = firstArray.Not();

        foreach (var item in resultNot)
        {
            Console.WriteLine(item);
        }
    }
}
