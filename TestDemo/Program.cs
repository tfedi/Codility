using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.solution(new[] { 1, 3, 6, 4, 1, 2 });
        }

        /*This is a demo task.
           
           Write a function:
           
           class Solution { public int solution(int[] A); }
           
           that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
           
           For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
           
           Given A = [1, 2, 3], the function should return 4.
           
           Given A = [−1, −3], the function should return 1.
           
           Write an efficient algorithm for the following assumptions:
           
           N is an integer within the range [1..100,000];
           each element of array A is an integer within the range [−1,000,000..1,000,000].
         */

        class Solution
        {
            public int solution(int[] A)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                var list = A.Where(x => (long)x > 0).OrderBy(x=>x).Distinct().ToList();
                if (list.Count == 0)
                    return 1;
                int i;

                for (i = 0; i < list.Count; i++)
                {
                    if (list[i] != i + 1)
                        return i + 1;
                }

                return i+1;
            }
        }
    }
}
