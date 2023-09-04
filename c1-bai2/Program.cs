using System;
namespace bai2c1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,kq=0;
            char toantu,tieptuc;
            while (true)
            {
                nhap(out a,out b,out toantu);
                Thuchien(a, b,toantu,ref kq);
                KQua(a, b,  toantu, ref  kq);
                Console.Write("Tiep tuc:");
                tieptuc = Convert.ToChar(Console.ReadLine());
                if (tieptuc=='T' | tieptuc=='t')
                {
                    break;
                }
            }
        }
        static void nhap(out double a,out double b,out char toantu)
        {   
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Toan tu:");
            toantu = Convert.ToChar(Console.ReadLine());
            
        }
        static void Thuchien(double a, double b, char toantu,ref double kq)
        {
            if (toantu == '+') {kq=a+b;}
            else if (toantu == '-') {kq=a-b;}
            else if (toantu == '*') {kq=a*b;}
            else if (toantu == '/') {kq=a/b;}
        }
        static void KQua(double a, double b, char toantu, ref double kq)
        {
            if (toantu == '/' & b == 0)
            {Console.WriteLine("Khong the thuc hien duoc phep tinh chia voi b=0");}
            else {Console.WriteLine("{0}{1}{2}={3}",a,toantu,b,kq);}
        }
    }
}
