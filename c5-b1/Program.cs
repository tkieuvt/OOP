using System;
class hinhtron
{
    public double r,d;
    public double s,pi=3.14;

    public hinhtron(double r,double d)
    {
        this.r = r;
        this.d = d;
    }
    public void xuat()
    {
        s = pi*r*r;
        Console.WriteLine($"Ban kinh: {r}, duong kinh: {d}, dien tich: {s}");
    }
}
class hinhcau: hinhtron
{
    public double v;
    public hinhcau(double bk,double dk, double thetich): base(bk,dk)
    {}
}
class Program
{
    static void Main(string[] args)
    {
        hinhtron a = new hinhtron(1,2);
        a.xuat();
    }
}