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
            int cur = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            SB.Start();
            for (int i = 1; i <= cur; i++)
            {
                sb.Append(i + " ");
            }
            SB.Stop();
            Console.WriteLine($"{sb}\nВитрачено часу на виконання:{SB.Elapsed}");
        }       
    }
}
