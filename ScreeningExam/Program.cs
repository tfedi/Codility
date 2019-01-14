namespace ScreeningExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.FindWord(new List<string> { "P>E", "E>R", "R>U" }));
            Console.WriteLine(solution.FindWord(new List<string> { "U>N", "G>A", "R>Y", "H>U", "N>G", "A>R" })); // HUNGARY
            Console.WriteLine(solution.FindWord(new List<string> { "I>F", "W>I", "S>W", "F>T" })); // SWIFT
            Console.WriteLine(solution.FindWord(new List<string> { "R>T", "A>L", "P>O", "O>R", "G>A", "T>U", "U>G" })); // PORTUGAL
            Console.WriteLine(solution.FindWord(new List<string>
            {
                "W>I",
                "R>L",
                "T>Z",
                "Z>E",
                "S>W",
                "E>R",
                "L>A",
                "A>N",
                "N>D",
                "I>T"
            })); // SWITZERLAND

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public string FindWord(List<string> rules)
        {
            List<string> firstLetters = new List<string>();
            List<string> secondLetters = new List<string>();
            Dictionary<string, string> letterRules = new Dictionary<string, string>();

            foreach (var rule in rules)
            {
                var first = string.Empty;
                var second = string.Empty;

                GetLetters(rule, out first, out second);

                firstLetters.Add(first);
                secondLetters.Add(second);

                letterRules.Add(first, second);
            }

            var wordBeginLetter = firstLetters.First(f => !secondLetters.Contains(f));
            bool existRuleLetter = true;
            var finalWord = string.Empty;

            var letterToAdd = wordBeginLetter;

            while (existRuleLetter)
            {
                finalWord += letterToAdd;
                existRuleLetter = letterRules.ContainsKey(letterToAdd);
                if (existRuleLetter)
                    letterToAdd = letterRules[letterToAdd];
            }

            return finalWord;
        }

        //public string FindWord(List<string> rules)
        //{
        //    List<string> word = new List<string>();
        //    var firstLetter = String.Empty;
        //    var secondLetter = String.Empty;

        //    for (int i = 0; i < rules.Count; i++)
        //    {
        //        GetLetters(rules[i], out firstLetter, out secondLetter);

        //    }

        //    foreach (var rule in rules)
        //    {
        //        GetLetters(rule, out firstLetter, out secondLetter);

        //        var indexFirstLetter = word.IndexOf(firstLetter);
        //        var indexSecondLetter = word.IndexOf(secondLetter);
        //        if (indexFirstLetter == -1 && indexSecondLetter == -1)
        //        {
        //            word.Add(firstLetter);
        //            word.Add(secondLetter);

        //        }
        //        else if(indexFirstLetter != -1 && indexSecondLetter == -1)
        //            word.Insert(indexFirstLetter+1, secondLetter);
        //        else if(indexFirstLetter == -1 && indexSecondLetter != -1)
        //            word.Insert(indexSecondLetter, firstLetter);
        //    }

        //    var finalWord = String.Empty;

        //    foreach (var letter in word)
        //    {
        //        finalWord += letter;
        //    }

        //    return finalWord;
        //}

        private static void GetLetters(string rule, out string first, out string second)
        {
            var letters = rule.Split('>');
            first = letters[0];
            second = letters[1];
        }
    }
}
