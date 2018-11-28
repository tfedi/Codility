namespace PermCheck
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*
     * A non-empty array A consisting of N integers is given.
      
      A permutation is a sequence containing each element from 1 to N once, and only once.
      
      For example, array A such that:
      
      A[0] = 4
      A[1] = 1
      A[2] = 3
      A[3] = 2
      is a permutation, but array A such that:
      
      A[0] = 4
      A[1] = 1
      A[2] = 3
      is not a permutation, because value 2 is missing.
      
      The goal is to check whether array A is a permutation.
      
      Write a function:
      
      class Solution { public int solution(int[] A); }
      
      that, given an array A, returns 1 if array A is a permutation and 0 if it is not.
      
      For example, given array A such that:
      
      A[0] = 4
      A[1] = 1
      A[2] = 3
      A[3] = 2
      the function should return 1.
      
      Given array A such that:
      
      A[0] = 4
      A[1] = 1
      A[2] = 3
      the function should return 0.
      
      Write an efficient algorithm for the following assumptions:
      
      N is an integer within the range [1..100,000];
      each element of array A is an integer within the range [1..1,000,000,000].
     */
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Solution();
            var array = new List<int>();
            for (int i = 1; i < 100001; i++)
            {
                array.Add(i);
            }
            Console.WriteLine(c.solution(array.ToArray()));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Distinct().Count() == A.Length)
            {
                long sum = A.Sum(x => (long) x);
                long sumLogica = A.Length * ((long)A.Length + 1)/ 2;
                if (sum == sumLogica)
                    return 1;
            }

            return 0;
        }
    }
}
