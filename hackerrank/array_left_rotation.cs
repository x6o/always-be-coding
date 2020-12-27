// Find the problem at https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the rotLeft function below.

    static int[] rotLeft(int[] a, int d)
    {
        // Submission #2, with Queues
        Queue<int> inputs = new Queue<int>(a.ToList());

        while (d-- > 0)
        {
            inputs.Enqueue(inputs.Dequeue());
        }

        return inputs;
    }

    // First submission, doesn't work 100% and is ugly
    // static int[] rotLeft(int[] a, int d)
    // {
    //     for (int nr = d; nr > 0; nr--)
    //     {
    //         int last = a[0];
    //         for (int i = 0; i < a.Length - 1; i++)
    //         {
    //             a[i] = a[i + 1];
    //         }
    //         a[a.Length - 1] = last;
    //     }
    //     return a;
    // }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
