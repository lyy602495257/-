using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[99];
            for (int i1 = 0; i1 < 99; i1++)
            {
                a[i1] = i1 + 2;
            }//给数组赋值2~100
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 0; j < 99; j++)
                {
                    if (a[j] != 0)
                    {
                        if (a[j] % i == 0 && a[j] / i != 1)
                        { a[j] = 0; }
                    }
                }
            }//筛选出素数，数组素数为本身，非素数为0
            Console.WriteLine("2~100以内的素数");
            int n = 0;
            for (int ii = 0; ii < 99; ii++)
            {
                if (a[ii] != 0)
                {
                    Console.WriteLine(a[ii] + " ");
                    n++;
                }
            }
        }
    }
}
