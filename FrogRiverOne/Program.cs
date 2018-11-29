using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.solution(5, new []{ 1, 3, 1, 4, 2, 3, 5, 4 });
            solution.solution(3, new []{ 1, 3, 1, 3, 2, 1, 3 });
        }
    }

    class Solution
    {
        public int solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var listAux = new bool[X+1];
            var trueCount = 0;

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int i = 0; i < A.Length; i++)
            {
                if (trueCount < X)
                    if (!listAux[A[i]])
                    {
                        trueCount++;
                        listAux[A[i]] = true;
                    }

                if (trueCount == X)
                    return i;
            }

            return -1;
        }
    }
}
