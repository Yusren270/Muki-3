using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static long InterativenVar(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            long N1 = 1;
            long N2 = 2;
            long result = 0;
            for(int i = 3; i <= n; i++)
            {
                result = N1 + N2;
                N1 = N2;
                N2 = result;
            }
            return result;
        }
        static long RekursivenVar(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            else
            {
                return 3*RekursivenVar(n-1)-RekursivenVar(n-2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("InternativenVar");
            Console.WriteLine(InterativenVar(n));
            Console.WriteLine("RekursivenVar");
            Console.WriteLine(RekursivenVar(n));
        }
    }
}
