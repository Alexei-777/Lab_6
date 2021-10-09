using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.    Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.

namespace Lab_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            String input = Console.ReadLine();
            String[] predlozenie = input.Split(new Char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            for (int i = 0; i < predlozenie.Length; i++)
            {
                if (predlozenie[i].Length > maxlen)
                {
                    maxlen = predlozenie[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", predlozenie[index]);
            Console.ReadLine();
        }
    }
}
