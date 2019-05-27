namespace MaxProductOfThree
{
    using System;
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

    public class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length == 1)
                return A[0];
            
            if(A.Length == 2)
                return A[0] * A[1];

            var sortedList = A.ToList().OrderByDescending(x => x).ToList();

            var multiplicationPositive = sortedList[0] * sortedList[1] * sortedList[2];
            var multiplicationNegative =
                sortedList[0] * sortedList[sortedList.Count - 1] * sortedList[sortedList.Count - 2];

            return multiplicationPositive > multiplicationNegative ? multiplicationPositive : multiplicationNegative;
        }
    }
}
