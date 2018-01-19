using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProb1
{
    class Program
    {
        // Complexity - n(logn)
        public bool Solution(int[] Arr)
        {
            int count = 0, length = Arr.Length;
            int[] ArrOriginal = new int[length];
            Array.Copy(Arr, ArrOriginal, length);
            Array.Sort(Arr);
            for (int i = 0; i < length; i++)
            {

                //Console.WriteLine(Arr[i] + " -- " + ArrOriginal[i]);

                if (Arr[i] != ArrOriginal[i])
                    count++;
            }
            Console.WriteLine("Need Swaps = " + (count>0 ? Math.Ceiling( Convert.ToDecimal( count)/2):0));
            if (count > 2)
                return false;
            else
            return true;

        }

        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Enter the length of array");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                int[] Arr = new int[n];
                Console.WriteLine("Enter Array Elements");
                for (int i = 0; i < n; i++)
                {
                    Arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Program obj = new Program();
                Console.WriteLine(obj.Solution(Arr));
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter Valid Integers..");
            }
            Console.Read();
        }
    }
}
