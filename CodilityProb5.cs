using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProb5
{
    class Program
    {
        public int Solution(int[] A)
        {

            Dictionary<int, int> B = new Dictionary<int, int>();
            foreach (int item in A)
            {
                if (!B.ContainsKey(item))
                    B.Add(item, 1);
                else
                {
                    int count = B[item];
                    B.Remove(item);
                    B.Add(item, ++count);
                    if (count >= (Math.Ceiling(Convert.ToDecimal(A.Length) / 2)))
                    {
                        Console.WriteLine("Leader = "+item);
                        return 1;
                    }
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] A = { 2, 5, 2, 1, 3, 5, 2, 2, 5, 5, 5, 5 };
            Console.WriteLine(p.Solution(A));
        }
    }
}
