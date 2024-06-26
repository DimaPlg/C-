﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class SumOfInterv
    {


        public static int SumInt((int, int)[] intervals)
        {
            int[,] arr = new int[intervals.Length, 2];

            int saze = intervals.Length;

            for (int i = 0; i < saze; i++)
            {
                arr[i, 0] = intervals[i].Item1;
                arr[i, 1] = intervals[i].Item2;
            }

            for (int i = 0; i < saze; i++)
            {
                for (int j = 0; j < saze; j++)
                {
                    if (arr[i, 0] > arr[j, 0] && arr[j, 1] <= arr[i, 1] && arr[j, 1] >= arr[i, 0])
                    {
                        arr[i, 0] = arr[j, 0];
                        arr[j, 0] = 0;
                        arr[j, 1] = 0;
                    }
                    if (arr[i, 0] <= arr[j, 0] && arr[j, 1] <= arr[i, 1] && arr[j, 1] - arr[j, 0] != 0 && i != j)
                    {
                        arr[j, 0] = 0;
                        arr[j, 1] = 0;
                    }
                    if (arr[i, 0] <= arr[j, 0] && arr[j, 0] < arr[i, 1] && arr[j, 1] > arr[i, 1])
                    {
                        arr[i, 1] = arr[j, 1];
                        arr[j, 0] = 0;
                        arr[j, 1] = 0;

                    }
                    if (arr[i, 0] > arr[j, 0] && arr[j, 1] > arr[i, 1])
                    {
                        arr[i, 0] = arr[j, 0];
                        arr[i, 1] = arr[j, 1];
                        arr[j, 0] = 0;
                        arr[j, 1] = 0;
                    }

                }
            }

            int result = 0;
            for (int i = 0; i < saze; i++)
            {
                result = result + arr[i, 1] - arr[i, 0];
            }
            return result;
        }
    }
}
/*
 * Sum of Intervals
 * 
 Write a function called sumIntervals/sum_intervals that accepts an array of intervals, and returns the sum of all the interval lengths. Overlapping intervals should only be counted once.

Intervals
Intervals are represented by a pair of integers in the form of an array. The first value of the interval will always be less than the second value. Interval example: [1, 5] is an interval from 1 to 5. The length of this interval is 4.

Overlapping Intervals
List containing overlapping intervals:

[
   [1, 4],
   [7, 10],
   [3, 5]
]
The sum of the lengths of these intervals is 7. Since [1, 4] and [3, 5] overlap, we can treat the interval as [1, 5], which has a length of 4.

Examples:
sumIntervals( [
   [1, 2],
   [6, 10],
   [11, 15]
] ) => 9

sumIntervals( [
   [1, 4],
   [7, 10],
   [3, 5]
] ) => 7

sumIntervals( [
   [1, 5],
   [10, 20],
   [1, 6],
   [16, 19],
   [5, 11]
] ) => 19

sumIntervals( [
   [0, 20],
   [-100000000, 10],
   [30, 40]
] ) => 100000030

ShouldHandleLargeRandomIntervals: don't work, check late.

 */