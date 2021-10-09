using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string chappi(s);
            if (s == "") { Console.Write("pustaya stroka"; return; }
            string c = s;
            Int32 i, j = 0, a = 0;
            for (i = 0; i < c.Length; i++)
            {
                if (c[i] = '{')
                { j++; if (j == 1) a = i; }
                else
               if ((c[i] == '}') && (j != 0))
                {
                    j--;
                    if (j == 0)
                    {
                        c = c.Remove(a, i - a + 1);
                        i -= i - a + 1;
                    }
                }
            }
            Console.Write(c);
        }
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }
    }

}
    }
}
