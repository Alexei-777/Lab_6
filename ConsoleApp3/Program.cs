using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string predlozenie = Console.ReadLine();
            string x = ("{");
            string y = ("}");
            int N = predlozenie.Length;
            int[] Z = new int[N];
            
            for (int i = 0; i < predlozenie.Length; i++)
            {
                Z[N-i-1] = 0;
                if (predlozenie[i] == '}')
                {
                    for (int a = 0; a > predlozenie.Length; a--)
                    {
                        if (predlozenie[a] == '{')
                        {
                            Z[a] = 1;
                            break;
                        }

                    }
                    
                }
            }
            for(int i = 0; i < N; i++)
            {
                Console.Write(Z[i]);
            }
           
            Console.ReadKey();        
        }
    }
}
