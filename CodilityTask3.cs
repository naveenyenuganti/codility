using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodlilityTask3
{
    class Program
    {
        int Solution(int[] A, int N)
        {
            int min = 0;
            for (int i = 1; i < N - 2; i++)
            {
                for (int j = i + 2; j < N - 1; j++)
                {
                    if (i == 1 && j == i + 2)
                        min = A[i] + A[j];
                    //Console.WriteLine(A[i] + A[j]);
                    if (A[i] + A[j] < min)
                    {
                        min = A[i] + A[j];
                    }
                }

            }

            return min;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] A = { 5, 2, 4, 6, 3, 7, 1, 5 };
            Console.WriteLine("\nMinimal Cost of division = " + p.Solution(A, A.Length));
        }
    }
}
