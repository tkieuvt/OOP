// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace bai4c1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n,n];
            int[] b = new int[n];
            for (int i=0; i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                    b[i] += a[i,j];
                }
                // Console.ReadLine();
            }
            CauA(b);
            CauB(n,a);
            CauC(n,a);
        }
        static void CauA(int []b)
        {
            int m = b[0];
            for (int i=1; i<b.Length;i++)
            {
                m = Math.Max(m,b[i]);
            }
            for (int i=0;i<b.Length;i++)
            {
                if (m==b[i]) Console.Write("{0} ",i+1);
            }
            Console.WriteLine();
        }
        static void CauB(int n,int [,]a)
        {
            int win,loser;
            for (int i=0;i<n;i++)
            {
                win = 0; loser = 0;
                for (int j=0;j<n;j++)
                {
                    if (a[i,j]==3) {win ++;}
                    else if (a[i,j]==0) {loser++;}
                }
                if (win>loser-1) {Console.Write("{0} ",i+1);}
            }
            Console.WriteLine();
        }
        static void CauC(int n,int [,]a)
        {
            int d;
            for (int i=0;i<n;i++)
            {
                d = 0;
                for (int j=0;j<n;j++)
                {
                    if (a[i,j]==0) {d++;}
                }
                if (d==1) {Console.Write("{0} ",i+1);}
            }
        }
    }
}