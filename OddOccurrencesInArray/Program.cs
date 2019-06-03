using System;
using System.Linq;

namespace OddOccurrencesInArray
{
    /*
    A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.

    For example, in array A such that:

    A[0] = 9  A[1] = 3  A[2] = 9
    A[3] = 3  A[4] = 9  A[5] = 7
    A[6] = 9
    the elements at indexes 0 and 2 have value 9,
    the elements at indexes 1 and 3 have value 3,
    the elements at indexes 4 and 6 have value 9,
    the element at index 5 has value 7 and is unpaired.
    Write a function:

    class Solution { public int solution(int[] A); }

    that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.

    For example, given array A such that:

    A[0] = 9  A[1] = 3  A[2] = 9
    A[3] = 3  A[4] = 9  A[5] = 7
    A[6] = 9
    the function should return 7, as explained in the example above.

    Write an efficient algorithm for the following assumptions:

    N is an odd integer within the range [1..1,000,000];
    each element of array A is an integer within the range [1..1,000,000,000];
    all but one of the values in A occur an even number of times.
    */
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.solution(new int[]{9,3,9,3,9,7,9}));
        }
    }

    class Solution {
        public int solution(int[] A)
        {
            //return (from val in A
            //        group val by val
            //                        into g
            //        select new { Value = g.Key, Count = g.Count() }).ToArray().Where(x => x.Count % 2 != 0).First().Value;
            int extension = A.Length;
            if (extension % 2 == 0)
            {
                return 0;
            }
            else
            {
                int result = 0;
                for (int i1 = 0; i1 < extension; i1++)
                {
                    int coincidencia = 0;

                    for (int i2 = 0; i2 < extension; i2++)
                    {
                        if (A[i1] == A[i2])
                        {
                            coincidencia++;
                        }

                        if (coincidencia == 1 && i2 == extension - 1)
                        {
                            result = A[i1];
                            break;
                        }
                    }

                    if (result != 0)
                    {
                        break;
                    }
                }

                return result;
            }
        }
    }
}
