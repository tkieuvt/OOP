// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace vidu
{
    class Program
    {
        static void Main (string[] args)
        { 
            int a,b,s=0;
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            TBPa (a, b);
        }
         static void TBPa (int a, int b)
        { 
            Console.WriteLine("a)Tong binh phuong {0}",a*a+b*b);
        }
        static void TBPb (out int a, out int b, int kq)
        {
            kq= a*a + b*b;
            Console.WriteLine("b)Tong binh phuong " + kq);
        }
        // static void TBPc (out int a, out int b, int kq)
        // {
        //     kq= a*a + b*b;
        //     Console.WriteLine("b)Tong binh phuong " + kq);
        // }

            // int i,n;
            // n = int.Parse(Console.ReadLine());
            // int [] a = new int[n];
            // for (i=1;i<=n;i++)
            // {
            //      a[i] = int.Parse(Console.ReadLine());
            // }
            // for (i=1;i<=n;i++)
            //     Console.WriteLine("Gio {0} co {1} san pham",i,a);

            // int i,j,S=0;
            // Console.Write("Nhap vao so luong bi gio do: ");
            // i = Convert.ToInt32(Console.ReadLine());
            // // i = int.Parse(Console.ReadLine())
            // j = Convert.ToInt32(Console.ReadLine());
            // S = i + j;
            // Console.WriteLine(S);
        //}
    }
}
