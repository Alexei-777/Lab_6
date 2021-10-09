using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            int z = 0;
            int[] X = new int[N];
            int[] Y = new int[N];
            int[] Z = new int[N];
            for (int i = 0; i < N; i++)
            {
                if (predlozenie[i] == x[0])
                {
                    X[i] = 1;
                }
                else
                {
                    X[i] = 0;
                }
                if (predlozenie[i] == y[0])
                {
                    Y[i] = 1;
                }
                else
                {
                    Y[i] = 0;
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(X[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                Console.Write(Y[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (Y[N - i - 1] == 1)
                {
                    z = 1;
                }
                else
                {
                    if (X[N - i - 1] == 1)
                    {
                        z = 0;
                    }
                    else
                    {
                        Z[N - i-1] = 1;
                    }
                }
                if (z == 1)
                {
                    Z[N - i - 1] = 1;
                }
                else
                {
                    Z[N - i - 1] = 0;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                Console.Write(Z[i]); 
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++) 
            {
                if (Z[i] == 0)
                {
                    Console.Write(predlozenie[i]);
                }
             }

            Console.ReadKey();
        }
    }
}
