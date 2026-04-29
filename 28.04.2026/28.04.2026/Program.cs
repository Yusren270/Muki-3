using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._04._2026
{
    internal class Program
    {
        static void Rekursiya(int n,List<int>list)
        {
            if (n <= 1)
            { 
                list.Add(int.Parse(Console.ReadLine()));
            }
            else
            {
                Rekursiya(n - 1, list);
                list.Add(int.Parse(Console.ReadLine()));
            }
        }
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n= int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            Rekursiya(n, list);
            Console.WriteLine(string.Join("--",list));
        }
    }
}
