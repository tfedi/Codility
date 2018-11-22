using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermMissingElem
{

    /*An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.

        Your goal is to find that missing element.

        Write a function:

        class Solution { public int solution(int[] A); }

        that, given an array A, returns the value of the missing element.

        For example, given array A such that:

          A[0] = 2
          A[1] = 3
          A[2] = 1
          A[3] = 5
        the function should return 4, as it is the missing element.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [0..100,000];
        the elements of A are all distinct;
        each element of array A is an integer within the range [1..(N + 1)].
        */
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.solution(new[]{2,3,1,5}));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length < 1)
                return 1;

            List<int> list = A.ToList();

            list = list.OrderBy(e => e).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (i+1 != list[i])
                {
                    return i+1;
                }
            }

            return list.Count + 1;
        }
    }
}
