// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");chuanop
using System;
using System.ComponentModel.DataAnnotations;
namespace bttl5c1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,x,y,d=0;
            string s;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[n];
            s = Console.ReadLine();
            a = s.Split();
            for (int i=0;i<n;i++)
            {
                x = Convert.ToInt32(a[i]);
                for (int j=i+1;j<n;j++)
                {
                    y = Convert.ToInt32(a[j]);
                    if (ucln(x,y)) 
                    {
                        Console.Write("{0} {1}; ",a[i],a[j]);
                        d += 1;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(d);
        }
        static bool ucln(int x,int y)
        {
            for (int i=2;i<=Math.Max(x,y);i++)
            {
                if (x%i==0 & y%i==0) {return false;}
            }
            return true;
        }
    }
} 