using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProb4
{
    class Program
    {
        int GetCount(LinkedList<string> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            string s;
            bool loop = true;
            while (loop)
            {
                s = Console.ReadLine();

                if (s.Equals("End"))
                {
                    loop = false;
                }
                else if (list.Count == 0)
                    list.AddFirst(s);
                else
                    list.AddLast(s);
            }
            Program p = new Program();
            Console.WriteLine("Length = " + p.GetCount(list));
        }


    }
}
