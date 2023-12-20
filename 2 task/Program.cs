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
            var SB = new Stopwatch();
            int n = int.Parse(Console.ReadLine());
            string cur = "";
            SB.Start();
            for (; n >= 1;)
            {
                cur = n + " " + cur;
                n--;
            }
            SB.Stop();
            Console.WriteLine($"{cur}\nЧас виконання:{SB.Elapsed}");
        }
    }
}
