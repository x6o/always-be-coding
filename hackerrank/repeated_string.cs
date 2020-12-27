// Find the problem at https://www.hackerrank.com/challenges/repeated-string/problem
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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {

        long count = 0;
        foreach (char c in s)
        {
            if (c == 'a') count++;
        }

        long factor = (n / s.Length);
        long rem = (n % s.Length);
        count = factor * count;

        for (int i = 0; i < rem; i++)
        {
            if (s[i] == 'a') count++;
        }

        return count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
