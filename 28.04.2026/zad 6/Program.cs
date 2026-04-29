using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_6
{
    internal class Program
    {
        static long GeometrichnaProgresiq(int n,int a1,int b)
        {
            if(n==1)
            {
                return a1;
            }
            else
            {
                return GeometrichnaProgresiq(n - 1, a1, b) * b;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("a1=");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            long result= GeometrichnaProgresiq(n, a1, b);
            Console.WriteLine(result);
        }
    }
}
