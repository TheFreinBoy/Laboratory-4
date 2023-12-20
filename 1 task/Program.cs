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
            string s = "";
            SB.Start();
            for (int i = 1; i <= n; i++)
            {
                s += i + " ";
            }
            SB.Stop();
            Console.WriteLine($"{s}\nВитрачено часу:{SB.Elapsed}");
        }
    }
}