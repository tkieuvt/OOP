// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace bai3slide
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,kq = 0;
            Console.WriteLine("Nhap 2 so: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            TBPa(a,b);
            TBPb(a, b, kq);
            Console.WriteLine("a)Tong binh phuong 2 so la: {0}", TBPc(a, b) );
        }
        static void TBPa(int a, int b)
        {
            Console.WriteLine("a)Tong binh phuong 2 so la: {0}",a*a+b*b);
        }
        static void TBPb(int a,int b, int kq)
        {
            kq = 0;
            kq = a*a+b*b;
            Console.WriteLine("b)Tong binh phuong 2 so la: {0}",kq);
        }
        static int TBPc( int a, int b)
        {
            return a*a+b*b;
        }
    }
}