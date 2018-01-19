using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 40, 40, 100, 80, 20 };
            int[] B = { 3, 3, 2, 2, 3 };
            Program p = new Program();
            Console.WriteLine(p.Solution(A, B, 3, 5, 200));
        }


        public int Solution(int[] A, int[] B, int M, int X, int Y)
        {

            int s = 0;
            long totalWeightPerRound = 0;
            int maxPersonsCount = 0;
            List<int> lstFloors = new List<int>();
            int currPerson = 0;
            bool start = false;
            while (currPerson < A.Length)
            {

                if ((totalWeightPerRound + A[currPerson]) <= Y && (maxPersonsCount + 1) <= X)
                {
                    totalWeightPerRound += A[currPerson];
                    maxPersonsCount++;
                    lstFloors.Add(B[currPerson]);

                    if (currPerson == A.Length - 1)
                        start = true;

                    currPerson++;
                }
                else
                {
                    start = true;
                }

                if (start)
                {
                    s += lstFloors.Distinct().Count() + 1;

                    lstFloors.Clear();
                    maxPersonsCount = 0;
                    totalWeightPerRound = 0;
                    start = false;
                }
            }

            return s;
        }
    }

}
