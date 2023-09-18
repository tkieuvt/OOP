using System;
namespace bttl6c1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,S=0;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gia tri lan luot cua cac mat hang la: ");
            string s = Console.ReadLine();
            string[] a = s.Split();
            int[] a_new = new int[n];
            for (int i=0;i<n;i++)
            {
                a_new[i] = Convert.ToInt32(a[i]);
                S += a_new[i];
            }
            Array.Sort(a_new);
            for (int i=0;i<(n/3);i++)
            {
                S -= a_new[i];
            }
            Console.WriteLine(S);
        }
    }
}