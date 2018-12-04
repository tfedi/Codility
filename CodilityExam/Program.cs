using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodilityExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutionA = new SolutionA();
            solutionA.solution(new string[1], new string[1]);

            var solutionB = new SolutionB();
            solutionB.solution(string.Empty);

            var solutionC = new SolutionC();
            solutionC.solution(21);

        }
    }

    class SolutionA
    {
        public int solution(string[] T, string[] R)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int maxNumberTask = 0;
            for (int i = 0; i < T.Length; i++)
            {
                var value = Int32.Parse(Regex.Match(T[i], @"\d+").Value);
                if (maxNumberTask < value)
                    maxNumberTask = value;
            }

            int[] scoresByGroup = new int[maxNumberTask];

            for (int i = 0; i < T.Length; i++)
            {
                var value = Int32.Parse(Regex.Match(T[i], @"\d+").Value);
                switch (R[i])
                {
                    case "OK":
                        if (scoresByGroup[value - 1] == 0)
                            scoresByGroup[value - 1] = 1;
                        break;
                    case "Wrong answer":
                    case "Time limit exceeded":
                    case "Runtime error":
                        scoresByGroup[value - 1] = -1;
                        break;
                }
            }

            int groupsApproved = scoresByGroup.Where(x => x == 1).Count();
            int totalGroups = scoresByGroup.Length;

            return (int)groupsApproved * 100 / totalGroups;
        }
    }

    class SolutionB
    {
        public string solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            return removePattern(S);
        }

        public string removePattern(string s)
        {
            string result = s;
            if (s.Contains("AA"))
                result = s.Replace("AA", "");
            else if (s.Contains("BB"))
                result = s.Replace("BB", "");
            else if (s.Contains("CC"))
                result = s.Replace("CC", "");


            if (result == s)
                return s;

            if (s.Length <= 1)
                return s;

            return removePattern(result);
        }
    }

    class SolutionC
    {
        public string solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            long L = 0;
            long R = 1;

            var result = getShortestSecuence(L, R, N);

            if (result.Contains("impossible"))
                return "impossible";
            return result;
        }

        public string getShortestSecuence(long L, long R, int N)
        {
            if (L == N || R == N)
                return "";
            if (L < N || R > N)
                return "impossible";

            long howMuchIClosedForL = 2 * L - R;
            long howMuchIClosedForR = 2 * R - L;
            long howMuchNextL = 2 * howMuchIClosedForL - R;
            long howMuchNextR = 2 * howMuchIClosedForR - L;

                if (N % howMuchIClosedForR == 0 &&  N % howMuchNextR == 0)
                    return "R" + getShortestSecuence(L, howMuchIClosedForR, N);
                return "L" + getShortestSecuence(howMuchIClosedForL, R, N);

        }
    }
}
