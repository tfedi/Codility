namespace CyclicRotation
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var aux = solution(new[]{ -4, -5, -6, -1, -2, -3}, 0);

            foreach (var i in aux)
            {
                Console.WriteLine($"{i},");
            }

            Console.ReadLine();
        }

        public static int[] solution(int[] A, int K)
        {
            if (A.Length <= 1 || K == 0)
                return A;

            int initialValue = A.Length;
            int contador = 0;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            while (contador < K)
            {
                initialValue--;
                if (initialValue < 0)
                    initialValue = A.Length - 1;

                contador++;
            }

            List<int> auxArray = new List<int>();

            while (auxArray.Count < A.Length)
            {
                auxArray.Add(A[initialValue]);
                initialValue++;
                if (initialValue == A.Length)
                    initialValue = 0;
            }

            return auxArray.ToArray();
        }
    }
}
