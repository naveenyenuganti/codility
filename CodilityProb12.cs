using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProb12
{
    class Program
    {
        public int Solution(String s)
        {
            int StrCount = 0, max = 0, Capcount = 0;
            char[] str = s.ToArray();
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    Capcount++;
                    StrCount++;
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    Capcount++;
                    StrCount++;
                }
                else
                {
                    if ((Capcount > 0 && StrCount > max))
                    {
                        max = StrCount;
                    }
                    StrCount = 0;
                    Capcount = 0;
                }

                if (i == str.Length - 1)
                {
                    if ((Capcount > 0 && StrCount > max))
                    {
                        max = StrCount;
                    }
                }


            }


            return max;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Solution("Asd0dAsd12dasdasdaKdasd"));
        }
    }
}
