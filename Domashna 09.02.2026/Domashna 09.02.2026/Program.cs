using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Domashna_09._02._2026
{
    internal class Program
    {
        static ArrayList class10A = new ArrayList();
        static void Input()
        {
            ArrayList s1 = new ArrayList();
            s1.Add("Ivan");
            s1.Add(new int[] { 5, 6, 6, 5 });

            ArrayList s2 = new ArrayList();
            s2.Add("Maria");
            s2.Add(new int[] { 6, 6, 5 });
            ArrayList s3 = new ArrayList();
            s3.Add("Georgi");
            s3.Add(new int[] { 4, 5 });

            class10A.Add(s1);
            class10A.Add(s2);
            class10A.Add(s3);
        }
        static void Main(string[] args)
        {
            Input();
            List<string> names = new List<string>();
            int studentsCount = class10A.Count;
            int[][] grades = new int[studentsCount][];

            for (int i = 0; i < class10A.Count; i++)
            {
                ArrayList student = (ArrayList)class10A[i];
                string name = "";
                int[] studentGrades = null;

                foreach (object item in student)
                {
                    if (item is string)
                        name = (string)item;

                    if (item is int[])
                        studentGrades = (int[])item;
                }
                names.Add(name);
                grades[i] = studentGrades;

            }
            for (int i = 0; i < grades.Length; i++)
            {
                double sum = 0;

                for (int j = 0; j < grades[i].Length; j++)
                    sum += grades[i][j];

                double avg = sum / grades[i].Length;

                Console.WriteLine($"{names[i]} -> Average: {avg:F2}");
            }
            int maxTests = 0;

          
            for (int i = 0; i < grades.Length; i++)
                if (grades[i].Length > maxTests)
                    maxTests = grades[i].Length;

            for (int test = 0; test < maxTests; test++)
            {
                double sum = 0;
                int count = 0;

                for (int i = 0; i < grades.Length; i++)
                {
                    if (test < grades[i].Length)
                    {
                        sum += grades[i][test];
                        count++;
                    }
                }

                Console.WriteLine($"Test {test + 1} average: {(sum / count):F2}");

            }
            int maxGrades = 0;

            for (int i = 0; i < grades.Length; i++)
                if (grades[i].Length > maxGrades)
                    maxGrades = grades[i].Length;

            Console.WriteLine("Students with most grades:");

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i].Length == maxGrades)
                    Console.WriteLine(names[i]);
            }
        }
    }
}
