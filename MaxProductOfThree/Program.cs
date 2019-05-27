using System;

namespace MaxProductOfThree
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            Console.WriteLine(sol.solution(new[] {-3, 1, 2, -2, 5, 6}));
            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length < 4)
            {
                var product = A[0];
                for (int i = 1; i < A.Length; i++)
                {
                    product *= A[i];
                }

                return product;
            }

            var maxProduct = A[0] * A[1] * A[2];

            for (int i = 1; i < A.Length; i++)
            {
                var product = 0;
                for (int j = i+1; j < A.Length; j++)
                {
                    for (int k = j+1; k < A.Length; k++)
                    {
                        product = A[i] * A[j] * A[k];

                        if (product > maxProduct)
                            maxProduct = product;
                    }
                }
            }

            return maxProduct;
        }
    }
}
