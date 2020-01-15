using System;
using System.Collections.Generic;
/*
Pascal's triangle is a triangular array of integers constructed with the following formula:
The first row consists of the number 1.
For each subsequent row, each element is the sum of the numbers directly above it, on either side.
For example, here are the first few rows:
    1
   1 1
  1 2 1
 1 3 3 1
1 4 6 4 1
Given an input k, return the kth row of Pascal's triangle.
Bonus: Can you do this using only O(k) space?
*/

namespace challenges.DCP
{
    public static class KthPascalTriangleRow {
        public static long[] GetKthRow(int k) {
            long[] prevLine = null;
            for (int i = 1; i <= k; i++) {
                if (i == 1) { 
                    prevLine = new long[] { 1 };
                } else if (i == 2) {
                    prevLine = new long[] { 1, 1 };
                } else {
                    long[] kthLine = new long[i];
                    kthLine[0] = kthLine[i-1] = 1;
                    for (int j = 0; j < prevLine.Length - 1; j++) {
                        kthLine[j+1] = prevLine[j] + prevLine[j+1];
                    }
                    prevLine = kthLine;
                }
            }
            return prevLine;
        }

        private static Dictionary<int, ulong> _factorials = new Dictionary<int, ulong>();
        private static void buildFactorialDictionary(int n) {
            _factorials.Add(0, 1);
            for (ulong i = 1; i <= (ulong)n; i++) {
                _factorials.Add((int)i, i * _factorials[(int)i-1]);
            }
        }

        public static ulong[] GetKthRowFactorialWay(int k) {
            int n = k - 1; // nth power => k+1th row
            buildFactorialDictionary(n);
            //Console.WriteLine("_factorials = [{0}]", string.Join(",", _factorials));
            ulong[] kthLine = new ulong[k];
            for (int i = 0; i < k; i++) {
                kthLine[i] = _factorials[n] / (_factorials[n-i] * _factorials[i]);
            }
            return kthLine;
        }
    }
}
