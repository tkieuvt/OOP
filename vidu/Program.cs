// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.ComponentModel.DataAnnotations;

namespace bai3c1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,iMax,iMin,tam;
            double tong=0,tich=1,maxx,minn;
            double[] a;
            //int[] le,chan;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (i=0;i<n;i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                if (a[i]<0) {tong += Math.Abs(a[i]);}
            }
            Console.WriteLine("Tong={0}",tong);
            //caub
            iMax = 0; maxx = a[0];
            iMin = 0; minn = a[0];
            for (i=1;i<n;i++)
            {
                if (maxx<a[i]) {maxx = a[i];iMax =i;}
                if (minn>a[i]) {minn = a[i];iMin =i;}
            }
            if (iMin>iMax) {tam = iMin;iMin = iMax;iMax = tam;}
            for (i=iMin+1;i<iMax;i++)
            {
                tich *= a[i];
            }
            Console.WriteLine("Tich={0}",tich);
            //cauc
            Array.Sort(a);
            foreach (int x in a)
            {
                Console.Write("{0} ",x);
            }
            //caud

        }
        
    }
}
