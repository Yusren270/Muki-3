using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class Program
    {
        static long Factoriel(long n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factoriel(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(n));
        }
    }
}
