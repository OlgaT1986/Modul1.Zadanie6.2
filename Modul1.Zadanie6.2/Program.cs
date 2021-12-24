using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string words, result, back;
            Console.WriteLine("Введите предложение без знаков препинания");
            words = Console.ReadLine();
            string[] split = words.Split(' ');
            result = "";
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    result = result + s;
                }
            }
            char[] reverse = result.Reverse().ToArray();
            back = "";
            foreach (Char ch in reverse)
            {
             back = back + ch;

            }
            if (string.Compare(result, back, true) == 0)
                Console.WriteLine("Строка является палиндром ");
            else Console.WriteLine("Строка не является палиндром ");
            Console.ReadKey();
        }
    }
}
