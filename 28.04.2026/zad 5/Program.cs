using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class Program
    {
        static int FindMin(int[]arr,int index)
        {
            if(index==arr.Length-1)
            {
                return arr[index];
            }
            else
            {
                int min= FindMin(arr, index + 1);
                return Math.Min(arr[index], min);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());  
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int result= FindMin(arr, 0);
            Console.WriteLine(result);
        }
    }
}
