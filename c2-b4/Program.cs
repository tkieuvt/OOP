// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;
class Triangle
{
    public double a,b,c,cv,s;
    public void nhap()
    {
        Console.WriteLine("ba gia tri la");
        Console.Write("a=");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b=");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c=");
        c = Convert.ToInt32(Console.ReadLine());
    }
    public void cv_dt()
    {
        cv = a+b+c;
        double p = (a+b+c)/2;
        s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    }
    public void xuat()
    {
        Console.WriteLine("ba gia tri duoc nhap la {0} {1} {2}",a,b,c);
        if (a+b>c & a+c>b & b+c>a)
        {
            Console.WriteLine("chu vi tam giac la {0}",cv);
            Console.WriteLine("Dien tich tam giac la {0}",s);
        }
        else {Console.WriteLine("Khong hop le!!!");}
    }
    public void menu()
    {
        Console.WriteLine("MENU\nBam 0: thoat khoi chuong trinh\nBam 1: nhap cac gia tri a,b,c\nBam 2: Tinh chu vi va dien tich cua tam giac\nBam 3: xuat cac gia trị a,b,c");
        int chucnang = 1;
        while (chucnang != 0 )
        {
            Console.Write("Chon chuc nang can thuc hien:");
            chucnang = Convert.ToInt16(Console.ReadLine());
            if (chucnang == 1) {nhap();}
            else if (chucnang == 2) {cv_dt();}
            else if (chucnang == 3) {xuat();}
        }
    }
}
class Program
{
    static void Main()
    {
        Triangle tg = new Triangle();
        tg.menu();
    }
}
