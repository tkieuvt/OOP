using System;
class hinhtron
{
    public double r,d;
    public double s;

    public hinhtron(double r)
    {
        this.r = r;
        d = 2*r;
        s = 3.14*r*r;
    }
    public void xuat()
    {
        Console.Write($"Ban kinh: {r}, duong kinh: {d}");
    }
    public void xuatS()
    {
        Console.WriteLine($", dien tich: {s}");
    }
}
class hinhcau: hinhtron
{
    public double v,S_cau;
    public hinhcau(double bk): base(bk)
    {
        S_cau = 4*s;
        v = 4/3*s*bk;
    }
    public new void xuat()
    {
        base.xuat();
        Console.WriteLine($", dien tich: {S_cau}, the tich: {v}");
    }
}
class hinhtru : hinhtron
{
    public double h,chuvi,s_day,s_xq,s_tp,v_tru;
    public hinhtru(double bk, double h) : base(bk)
    {
        this.h = h;
        chuvi = 2*3.14*bk;
        s_day = s;
        s_xq = s*h;
        s_tp = s_xq + chuvi;
        v_tru = s_day * h;
    }
    public new void xuat()
    {
        base.xuat();
        Console.WriteLine($", chieu cao: {h}, chu vi mat day: {chuvi}, dien tich mat day: {s_day}, dien tich xung quanh: {s_xq}, dien tich toan phan: {s_tp}, the tich hinh tru: {v_tru}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ban kinh hinh tron la: ");
        double R = Convert.ToDouble(Console.ReadLine());
        hinhtron a = new hinhtron(R);
        Console.Write("--HINH TRON--");
        a.xuat();
        a.xuatS();
        Console.Write("Ban kinh hinh cau la: ");
        R = Convert.ToDouble(Console.ReadLine());
        hinhcau b = new hinhcau(R);
        Console.Write("--HINH CAU--");
        b.xuat();
        Console.Write("Ban kinh hinh tru la: ");
        R = Convert.ToDouble(Console.ReadLine());
        Console.Write("Chieu cao hinh tru la: ");
        double h = Convert.ToDouble(Console.ReadLine());
        hinhtru c = new hinhtru(R,h);
        Console.Write("--HINH TRU--");
        c.xuat();
    }
}
