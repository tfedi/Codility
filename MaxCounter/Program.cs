using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.solution(5, new[] {3, 4, 4, 6, 1, 4, 4});
            solution.solution(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 });

        }

        class Solution
        {
            public int[] solution(int N, int[] A)
            {
                int[] numbers = new int[N + 1];
                int maxValueToBeSet = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] <= N)
                    {
                        if (numbers[A[i]] < maxValueToBeSet)
                        {
                            numbers[A[i]] = maxValueToBeSet;
                        }

                        numbers[A[i]]++;
                        if (numbers[A[i]] > numbers[0])
                            numbers[0]++;
                    }
                    else
                    {
                        maxValueToBeSet = numbers[0];
                    }
                }

                for (int i = 1; i < N + 1; i++)
                {
                    if (numbers[i] < maxValueToBeSet)
                        numbers[i] = maxValueToBeSet;
                }

                return numbers.Skip(1).ToArray();
            }
        }
    }
}
