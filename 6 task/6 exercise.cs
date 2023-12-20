using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Text;
using System.ComponentModel;

namespace Da
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write($"6. Введіть рядок:");
            string word = Console.ReadLine();
            int count = Counting(ref word);
            Console.WriteLine($"Результат: {word}");
            Console.WriteLine($"Кількість cd = {count}");
        }
        public static int Counting(ref string word)
        {
            int count = 0;
            for(int i = 0; i < word.Length - 1; i++)
            {
                if(word.Substring(i, 2) == "cd")
                {
                    count++;
                }
            }          
            for (int i = 1; i < word.Length - 1; i++)
            {                                                                     
                if (word.Substring(i - 1, 3) == "bcd")
                {
                     word = word.Remove(i, 2);                          
                }                                   
            }
            return count;
            
        }
    }
}
