// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");chuanop
using System;
namespace bttl4c1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,d = 0;
            n = Convert.ToInt32(Console.ReadLine());
            while (n>0)
            {
                d += n%10;
                n /=10;
                if (n==0 & d>9) {n = d;d = 0;}
            }
            Console.WriteLine(d);
        }
    }
}