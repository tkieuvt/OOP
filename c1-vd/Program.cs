// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace vidu
{
    class Program
    {
        static void Main (string[] args)
        { 
            int n = 0;
            string s;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            string[,] a = new string[n,n];
            for (int i=0;i<n;i++)
            {
                s = Console.ReadLine();
                a[i] = s.Split();
            }
        }
    }
}
