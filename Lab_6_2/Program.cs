using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.    Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
//Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).

namespace Lab_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string predlozenie = Console.ReadLine();
            predlozenie = predlozenie.Replace(" ", string.Empty); // уберем пробелы
            Console.WriteLine($"Уберем пробелы: {predlozenie}");
            predlozenie = predlozenie.ToLower();// уберем заглавные
            Console.WriteLine($"Уберем верний регистор: {predlozenie}");
            byte x = 0;
            for (int i = 0; i < predlozenie.Length; i++) // сравнение
            {
                if (predlozenie[i] != predlozenie[predlozenie.Length - i - 1])
                    x = 1;
            }
            if (x == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Палиндромом");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Не палиндромом");
            }
            Console.ReadKey();
        }
    }
}
