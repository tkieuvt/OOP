// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace bttl1c1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,d=0;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i=a;i<=b;i++)
            {
                if (snt(i)) {d++;}
            }
            Console.WriteLine(d);
        }
        static Boolean snt(int x)
        {
            for (int i=2;i<=(Math.Sqrt(x));i++)
            {
                if (x%i==0) {return false;}
            }
            return true;
        }
    }
}