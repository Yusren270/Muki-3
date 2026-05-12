using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._05._2026
{
    internal class Program
    {
        static long Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Vuvedi N-to chislo:");
            int n = int.Parse(Console.ReadLine());
            long fib=Fibonacci(n);
            Console.WriteLine(fib);
        }
    }
}
