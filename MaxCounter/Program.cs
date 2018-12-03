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
            solution.solution(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 });

        }

        class Solution
        {
            public int[] solution(int N, int[] A)
            {
                int[] numbers = new int[N+1];

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] <= N)
                    {
                        numbers[A[i]]++;
                        if (numbers[A[i]] > numbers[0])
                            numbers[0]++;
                    }
                    else
                    {
                        for (int x = 1; x < N + 1; x++)
                        {
                            numbers[x] = numbers[0];
                        }
                    }
                }
                return numbers.Skip(1).ToArray();

            }
        }
    }
}
