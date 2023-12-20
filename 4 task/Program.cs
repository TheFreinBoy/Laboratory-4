using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Text;

namespace Da
{
    internal class Program
    {     
        static void Main()
        {
            var SW = new Stopwatch();
            int n = int.Parse(Console.ReadLine());                       
            StringBuilder cur = new StringBuilder();
            SW.Start();
            for (; n >= 1;)
            {
                cur.Insert(0, n + " ");
                n--;
            }
            SW.Stop();
            Console.WriteLine($"{cur}\nВитарчено часу на виконання:{SW.Elapsed}");            
        }       
    }
}
