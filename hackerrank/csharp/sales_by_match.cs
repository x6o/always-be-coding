// Find the problem at https://www.hackerrank.com/challenges/sock-merchant/problem
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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        Dictionary<int, int> sort = new Dictionary<int, int>();

        int number = 0;
        foreach (int sock in ar)
        {
            if (sort.ContainsKey(sock))
            {
                sort[sock] += 1;
            }
            else
            {
                sort.Add(sock, 1);
            }
        }

        foreach (int key in sort.Keys)
        {
            int total = sort[key];
            int mod = total % 2;

            if (mod == 0)
            {
                number += total / 2;
            }
            else
            {
                number += (total - mod) / 2;
            }
        }

        return number;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
