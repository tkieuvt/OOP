// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace bttl2c1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            tinh(n);
        }
        static void tinh(int n)
        {
            double t=0;
            // for (double i=2;i<=n;i++)
            // {
            //     s = s*(2*i-1);
            // }
            for (double i=1;i<=n;i++)
            {
                t = t + 1/((2*i)-1);
            }
            Console.WriteLine("tong={0}",t);
        }
    }
}