using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodililtyProb4
{
    class Program
    {
        public int Solution(int[] A, int[] B) {
            decimal[] C = new decimal[A.Length];
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = Convert.ToDecimal(((A[i] * 1000000) + B[i]))/ 1000000;
                Console.WriteLine(C[i]);
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i+1; j < A.Length; j++)
                {
                    if ((C[i]*C[j]) >= (C[i] + C[j]))
                    {
                      //  Console.WriteLine(i+"  "+j+"  "+(C[i] * C[j]) +" >= "+ (C[i] + C[j]) + " =====> " +C[i]+" "+C[j]);
                        count++;
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] A = { 0, 1, 2, 2, 3, 5 };
            int[] B = { 500000, 500000, 0, 0, 0, 20000 };
            Console.WriteLine( "Count = "+ p.Solution(A, B)); 
        }
    }
}
