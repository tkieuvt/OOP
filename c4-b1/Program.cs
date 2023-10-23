// See https://aka.ms/new-console-template for more information
using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
class Phanso
{
    int tuso,mauso;
    public Phanso(){}
    public Phanso(int tuso,int mauso)
    {
        this.tuso=tuso;
        this.mauso=mauso;
    }
    public void nhap()
    {
        Console.Write("Nhap tu so: ");
        tuso = Convert.ToInt32(Console.ReadLine());
        while (mauso==0)
        {
        Console.Write("Nhap mau so: ");
        mauso = Convert.ToInt32(Console.ReadLine());
        }
    }
    public Phanso Tong(Phanso a,Phanso b)
    {
        Phanso c = new Phanso();
        tuso = a.tuso*b.mauso + a.mauso*b.tuso;
        mauso = a.mauso*b.mauso;
        int u = gdc(tuso,mauso);
        tuso = tuso/u;
        mauso = mauso/u;
        return c;
    }
    public Phanso Hieu(Phanso a,Phanso b)
    {
        Phanso c = new Phanso();
        tuso = a.tuso*b.mauso - a.mauso*b.tuso;
        mauso = a.mauso*b.mauso;
        int u = gdc(tuso,mauso);
        tuso = tuso/u;
        mauso = mauso/u;
        return c;
    }
    public Phanso Tich(Phanso a,Phanso b)
    {
        Phanso c = new Phanso();
        tuso = a.tuso*b.tuso;
        mauso = a.mauso*b.mauso;
        int u = gdc(tuso,mauso);
        tuso = tuso/u;
        mauso = mauso/u;
        return c;
    }
    public Phanso Thuong(Phanso a,Phanso b)
    {
        Phanso c = new Phanso();
        tuso = a.tuso*b.mauso;
        mauso = a.mauso*b.tuso;
        int u = gdc(tuso,mauso);
        tuso = tuso/u;
        mauso = mauso/u;
        return c;
    }
    public int gdc(int a,int b)
    {
        if (a<0) {a = -a;}
        if (b<0) {b = -b;}
        while (a!=b)
        {
            if (a>b) {a -= b;}
            else {b -= a;}
        }
        return a;
    }
    public void Xuat()
    {
        Console.WriteLine("{0}/{1}",tuso,mauso);
    }
}
class c4bai1
{
    static void Main(string[] args)
    {
        Phanso ps1 = new Phanso(1,5);
        Phanso ps2 = new Phanso();
        ps2.nhap();

        Phanso tong = new Phanso();
        tong.Tong(ps1,ps2);
        Console.Write("Tong 2 phan so: ");
        tong.Xuat();

        Phanso hieu = new Phanso();
        hieu.Hieu(ps1,ps2);
        Console.Write("Hieu 2 phan so: ");
        hieu.Xuat(); 

        Phanso tich = new Phanso();
        tich.Tich(ps1,ps2);
        Console.Write("Tich 2 phan so: ");
        tich.Xuat();

        Phanso thuong = new Phanso();
        thuong.Thuong(ps1,ps2);
        Console.Write("Thuong 2 phan so: ");
        thuong.Xuat();   
    }
}
