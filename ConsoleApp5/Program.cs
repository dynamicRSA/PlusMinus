/*
Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros. Print the decimal value of each fraction on a new line.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.

Input Format

The first line contains an integer, , denoting the size of the array. 
The second line contains  space-separated integers describing an array of numbers .

Output Format

You must print the following  lines:

A decimal representing of the fraction of positive numbers in the array compared to its size.
A decimal representing of the fraction of negative numbers in the array compared to its size.
A decimal representing of the fraction of zeros in the array compared to its size.
Sample Input
6
-4 3 -9 0 4 1   

Sample Output

0.500000
0.333333
0.166667
Explanation

There are  positive numbers,  negative numbers, and  zero in the array. 
 */
using System;
namespace PlusMinus
{
    internal class Solution
    {

        // Complete the plusMinus function below.
        private static void PlusMinus(int[] arr)
        {
            var countPos = 0;
            var countNeg = 0;
            var countZero = 0;

            foreach (var item in arr)
            {
                if (item == 0)
                {
                    countZero++;
                }
                else if (item > 0)
                {
                    countPos++;
                }
                else if (item < 0)
                {
                    countNeg++;
                }
            } 
            Console.WriteLine((decimal)countPos/arr.Length);
            Console.WriteLine((decimal)countNeg /arr.Length);
            Console.WriteLine((decimal)countZero /arr.Length);
        }

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            var arr = Array.ConvertAll(Console.ReadLine()?.Split(' ') ?? throw new InvalidOperationException(), Convert.ToInt32);

            PlusMinus(arr);
            Console.ReadLine();
        }
    }
}