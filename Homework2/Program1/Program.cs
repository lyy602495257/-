using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " ";
            int n = 0;
            Console.WriteLine("请输入一个整数：");
            s = Console.ReadLine();
            n = int.Parse(s);
            int i = 2;
            Console.WriteLine("它的素数为：" );
            while (n >= i)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(" " + i);
                    while (n % i == 0)
                        n /= i;
                }
                i++;
            }
        }
    }
}
