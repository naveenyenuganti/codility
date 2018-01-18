using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProb8
{
    class Program
    {
        public int Solution(int[] A) {
            int orginal = 0, sum = 0, min = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                orginal = orginal + A[i];
                sum = sum + Math.Abs(orginal);
                Console.WriteLine(orginal+" "+sum);
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] A = { };
        }
    }
}
