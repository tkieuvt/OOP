// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace bttl3c1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b,s="";
            Console.Write("A=");
            a = Console.ReadLine();
            Console.Write("B=");
            b = Console.ReadLine();
            for (int i=0;i< a.Length;i++)
            {
                s += a[i]^b[i];
            }
            Console.WriteLine("A XOR B={0}",s);
        }
    }
}
