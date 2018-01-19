using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProb2
{
    class Program
    {
        public int solution(int[] Arr)
        {
            int count = 0, value = 0;
            value = Arr[0];
            count++; 
            while (value != -1)
            {
                count++;
                value = Arr[value];    
            }

            return count;
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
                Console.WriteLine("-------------");
                Console.WriteLine(obj.solution(Arr));
                Console.WriteLine("-------------");
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter Valid Integers..");
            }
            Console.Read();
        }
    }
}
