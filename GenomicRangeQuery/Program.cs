namespace GenomicRangeQuery
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var solution = new SolutionGenomicRangeQuery();

            solution.solution("CAGCCTA", new[] {2, 5, 0}, new[] {4, 5, 6});
        }
    }

    public class SolutionGenomicRangeQuery
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            if (P.Length > 0)
            {
                int[,] factors = new int[4, S.Length + 1];
                List<int> contadores = new List<int> { 0, 0, 0, 0 };
                List<int> minimalResult = new List<int>();

                for (int i = 0; i < S.Length; i++)
                {
                    contadores[0] = 0;
                    contadores[1] = 0;
                    contadores[2] = 0;
                    contadores[3] = 0;

                    switch (S[i])
                    {
                        case 'A':
                            contadores[0] = 1;
                            break;
                        case 'C':
                            contadores[1] = 1;
                            break;
                        case 'G':
                            contadores[2] = 1;
                            break;
                        case 'T':
                            contadores[3] = 1;
                            break;
                    }
                    factors[0, i + 1] = factors[0, i] + contadores[0];
                    factors[1, i + 1] = factors[1, i] + contadores[1];
                    factors[2, i + 1] = factors[2, i] + contadores[2];
                    factors[3, i + 1] = factors[3, i] + contadores[3];
                }

                var len = P.Length;
                List<int> auxiliarMinValues = new List<int>();
                for (int i = 0; i < len; i++)
                {
                    if (factors[0, Q[i] + 1] - factors[0, P[i]] > 0) minimalResult.Add(1);
                    else if (factors[1, Q[i] + 1] - factors[1, P[i]] > 0) minimalResult.Add(2);
                    else if (factors[2, Q[i] + 1] - factors[2, P[i]] > 0) minimalResult.Add(3);
                    else minimalResult.Add(4);
                }

                var array = minimalResult.ToArray();
                return array;
            }

            return new[] { 0 };
        }
    }
}
