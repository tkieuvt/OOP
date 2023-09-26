// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Concurrent;
class Sach
{
    public string Tensach, Tacgia;
    public int NamXB, Soluong;
    public void nhap()
    {
        Console.Write("Ten sach la ");
        Tensach = Console.ReadLine();
        Console.Write("Tac gia la ");
        Tacgia = Console.ReadLine();
        Console.Write("Nam xuat ban la ");
        NamXB = Convert.ToInt32(Console.ReadLine());
        Console.Write("So luong ");
        Soluong = Convert.ToInt32(Console.ReadLine());
    }
    public Sach(string a,string b,int c,int d)
    {
        Tensach = a;
        Tacgia = b;
        NamXB = c;
        Soluong = d;
    }
    public Sach()
    {
        Tensach = "Dac nhan tam";
        Tacgia = "DALE Carnegie";
        NamXB = 1936;
        Soluong = 15;
    }
    public void xuat()
    {
        Console.WriteLine("Ten sach la {0}, duoc viet boi tac gia {1}, xuat ban nam {2}, voi so luong {3} quyen",Tensach,Tacgia,NamXB,Soluong);
    }
}
class Program
{
    static void Main()
    {
        Sach book1 = new Sach();
        Sach book2 = new Sach("Dac nhan tam","Dale Carnegie",1936,15);
        Sach book3 = new Sach();
        book1.nhap();
        book1.xuat();
        book2.xuat();
        book3.xuat();
    }
}
