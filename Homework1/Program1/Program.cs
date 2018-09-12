using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " ";
            int n = 0;
            int d = 0;
            Console.Write("Please input an int:");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.Write("Please input an int:");
            s = Console.ReadLine();
            d = Int32.Parse(s);
            Console.WriteLine("Their product is :" + (n * d) );
        }
    }
}
