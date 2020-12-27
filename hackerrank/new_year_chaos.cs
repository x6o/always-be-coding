// Find the problem at https://www.hackerrank.com/challenges/new-year-chaos/problem
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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int bribes = 0;
        int expectedFirst = 1;
        int expectedSecond = 2;
        int expectedThird = 3;

        for (int i = 0; i < q.Length; i++)
        {
            if (q[i] == expectedFirst)
            {
                expectedFirst = expectedSecond;
                expectedSecond = expectedThird;
                expectedThird++;
            }
            else if (q[i] == expectedSecond)
            {
                bribes++;
                expectedSecond = expectedThird;
                expectedThird++;
            }
            else if (q[i] == expectedThird)
            {
                bribes += 2;
                expectedThird++;
            }
            else
            {
                Console.WriteLine("Too chaotic");
                return;
            }
        }

        Console.WriteLine(bribes);
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
