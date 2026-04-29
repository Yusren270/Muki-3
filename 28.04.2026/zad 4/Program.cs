using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class Program
    {
        static int StepenRekursiya(int a,int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return a * StepenRekursiya(a, n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Negative num:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Stepen:");
            int n = int.Parse(Console.ReadLine());
            if(n>0 || n%2==0)
            {
                int res= StepenRekursiya(a, n);
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("n trqbwa da e otricatelno");
            }
        }
    }
}
