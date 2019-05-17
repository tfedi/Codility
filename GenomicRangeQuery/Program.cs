namespace GenomicRangeQuery
{
    using System;
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
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (P.Length > 0)
            {
                int[] A = new int[S.Length];
                int[] C = new int[S.Length];
                int[] G = new int[S.Length];
                int[] T = new int[S.Length];
                List<int> minimalResult = new List<int>();

                for (int i = 0; i < S.Length; i++)
                {
                    switch (S[i])
                    {
                        case 'A':
                            A[i] = 1;
                            break;
                        case 'C':
                            C[i] = 1;
                            break;
                        case 'G':
                            G[i] = 1;
                            break;
                        case 'T':
                            T[i] = 1;
                            break;
                    }
                }

                var len = P.Length;
                for (int i = 0; i < len; i++)
                {
                    long minValue = Int64.MaxValue;

                    minValue = compare(A[Q[i]], A[P[i]], minValue);
                    if(minValue!= Int64.MaxValue)
                        minimalResult.Add(1);
                    else
                    {
                        minValue = compare(C[Q[i]], C[P[i]], minValue);
                        if(minValue != Int64.MaxValue)
                            minimalResult.Add((int)minValue * 2);
                        else
                        {
                            minValue = compare(G[Q[i]], G[P[i]], minValue);
                            if (minValue != Int64.MaxValue)
                                minimalResult.Add((int)minValue * 3);
                            else
                            {
                                minValue = compare(T[Q[i]], T[P[i]], minValue);
                                minimalResult.Add((int)minValue * 4);
                            }
                        }

                    }
                }

                var array = minimalResult.ToArray();
                return array;
            }

            return new[] {0};
        }

        private long max(long p0, long p1)
        {
            if (p0 >= p1)
                return p0;

            return p1;
        }

        private long min(long p0, long p1)
        {
            if (p0 <= p1)
                return p0;

            return p1;
        }

        private long compare(long last, long first, long minValue)
        {
            var impact = last - first;
            if (impact > 0 && minValue > impact)
                minValue = impact;
            return minValue;
        }
    }
}
