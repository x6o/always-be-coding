// Find the problem at https://www.hackerrank.com/challenges/utopian-tree/problem
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

class Solution {

    // Complete the utopianTree function below.
    static int utopianTree(int n) {
        /*
        Period  Height
        0          1
        1          2
        2          3
        3          6
        4          7
        5          14
        6          15
        7          30
        8          31
        9          42
        10         43
        11         86
        12         87
        ...        ...
        */
        
        int height = 1;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 > 0)
                height++;    
            else 
                height *= 2;
        }
        return height;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
