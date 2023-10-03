// See https://aka.ms/new-console-template for more information
using System;
using System.Data.Common;
class Meo
{
    public string ten, giong, gioitinh;
    public int tuoi;
    public static int dem=0;
    public void nhap()
    {
        Console.Write("Ten meo la ");
        ten = Console.ReadLine();
        Console.Write("Giong la ");
        giong = Console.ReadLine();
        Console.Write("Gioi tinh la ");
        gioitinh = Console.ReadLine();
        Console.Write("Tuoi ");
        tuoi = Convert.ToInt16(Console.ReadLine());
    }
    public Meo(string a, string b, string c, int d)
    {
        ten = a;
        giong = b;
        gioitinh = c;
        tuoi = d;
        dem +=1;
    }
    public Meo()
    {
        ten = "Ka";
        giong = "long den";
        gioitinh = "cai";
        tuoi = 2;
        dem +=1;
    }
    public void xuat()
    {
        Console.WriteLine("Ten meo la {0}, giong {1}, gioi tinh {2}, {3} tuoi",ten, giong, gioitinh, tuoi);
    }
    public static int Dem()
    {
        return dem;
    } 
}
class Program
{
    static void Main(string[] args)
    {
        Meo cat1 = new Meo();
        Meo cat2 = new Meo("Ca","long ngan","duc",2);
        Meo cat3 = new Meo();
        cat1.nhap();
        cat1.xuat();
        cat2.xuat();
        cat3.xuat();
        Console.WriteLine("so luong meo: {0}",Meo.Dem());
    }
}
