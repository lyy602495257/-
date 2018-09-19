using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 11, 4, 8, 2, 1, 9, 7 };
            Console.WriteLine("数组元素为：" + "5, 11, 4, 8, 2, 1, 9, 7");
            Array.Sort(numbers);
            Console.WriteLine("最大值为：" + numbers[7]);
            Console.WriteLine("最小值为：" + numbers[0]);
            double b = 0;
            double c = 0;
            foreach(int i in numbers)
            {
                b += i;
                c = b / 8;
            }
            Console.WriteLine("和为：" + b);
            Console.WriteLine("平均值为：" + c);
        }
    }
}
