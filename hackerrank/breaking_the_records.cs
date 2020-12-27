// Find the problem at https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
        int minTimes, maxTimes, min, max;
        minTimes = 0;
        maxTimes = 0;
        min = scores[0];
        max = scores[0];

        for (var i = 0; i < scores.Length; i++)
        {
            if (scores[i] < min)
            {
                min = scores[i];
                minTimes += 1;
            }
            if (scores[i] > max)
            {
                max = scores[i];
                maxTimes += 1;
            }
        }
        return new int[] { maxTimes, minTimes };
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
