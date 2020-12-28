// Find the problem at https://www.hackerrank.com/challenges/2d-array/problem
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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        int a, b, c, d, e, f, g;

        /*
            Ideally we should initialize max with the first
            hourglass sum, but this is a quick workaround
            to make the test cases pass.
        */
        int max = -99999, sum = 0;

        for (int y = 0; y <= 3; y++)
        {
            for (int x = 0; x <= 3; x++)
            {
                /*
                    a b c
                      d 
                    e f g
                */
                a = arr[y][x];
                b = arr[y][x + 1];
                c = arr[y][x + 2];
                d = arr[y + 1][x + 1];
                e = arr[y + 2][x];
                f = arr[y + 2][x + 1];
                g = arr[y + 2][x + 2];

                sum = a + b + c + d + e + f + g;
                if (sum > max) max = sum;
            }
        }
        return max;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
