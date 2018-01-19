using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProb14
{
    class Program
    {
        public int Solution(int A, int B)
        {
            int Rem = A * B, count = 0;
            while (Rem != 0)
            {
                if (Rem % 2 != 0)
                {
                    count++;
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
                Rem = Rem / 2;
                
            }

            return count;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int A, B;
            Console.WriteLine("Enter Any Two Integers");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNumber of 1's  =  " + p.Solution(A, B));
        }
    }
}
