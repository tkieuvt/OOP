using System;
class Hinhhoc
{
    public virtual void chuvi()
    {
        Console.WriteLine();
    }
    public virtual void dientich()
    {
        Console.WriteLine();
    }
}
class HinhChuNhat : Hinhhoc
{
    public float dai,rong;
    public HinhChuNhat(float dai,float rong)
    {
        this.dai = dai;
        this.rong = rong;
    }
    public override void chuvi()
    {
        Console.WriteLine("Chu vi : {0}",(dai+rong)*2);
    }
    public override void dientich()
    {
        Console.WriteLine("Dien tich : {0}",dai*rong);
    }
}
class Hinhtron : Hinhhoc
{
    public float r;
    public Hinhtron(float r)
    {
        this.r = r;
    }
    public override void chuvi()
    {
        Console.WriteLine("Chu vi : {0}",Math.Round(2*r*Math.PI,2));
    }
    public override void dientich()
    {
        Console.WriteLine("Dien tich : {0}",Math.Round(r*r*Math.PI,2));
    }
}
class HinhTamGiac : Hinhhoc
{
    public float a,b,c;
    public HinhTamGiac(float a,float b,float c)
    {
        this.a = a;this.b = b;this.c = c;
    }
    public override void chuvi()
    {
        if (a+b>c & a+c>b & b+c>a)
            {Console.WriteLine("Chu vi : {0}",a+b+c);}
        // else {Console.WriteLine("Khong phai tam giac");}
    }
    public override void dientich()
    {
        if (a+b>c & a+c>b & b+c>a)
            {
                double p = (a+b+c)/2;
                double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                Console.WriteLine("Dien tich : {0}",Math.Round(s,2));
            }
    }
}
class HinhVuong : Hinhhoc
{
    public float a;
    public HinhVuong(float a)
    {
        this.a = a;
    }
    public override void chuvi()
    {
        Console.WriteLine("Chu vi : {0}",4*a);
    }
    public override void dientich()
    {
        Console.WriteLine("Dien tich : {0}",a*a);
    }
}
class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("---HINH CHU NHAT---");
        Console.Write("Dai: ");
        float dai=float.Parse(Console.ReadLine());
        Console.Write("Rong: ");
        float rong=float.Parse(Console.ReadLine());
        HinhChuNhat hcn=new HinhChuNhat(dai,rong);
        hcn.chuvi();
        hcn.dientich();
        Console.WriteLine("---HINH TRON---");
        Console.Write("Ban kinh: ");
        float r=float.Parse(Console.ReadLine());
        Hinhtron ht=new Hinhtron(r);
        ht.chuvi();
        ht.dientich();
        Console.WriteLine("---HINH TAM GIAC---");
        Console.Write("Canh thu 1: ");
        float a=float.Parse(Console.ReadLine());
        Console.Write("Canh thu 2: ");
        float b=float.Parse(Console.ReadLine());
        Console.Write("Canh thu 3: ");
        float c=float.Parse(Console.ReadLine());
        HinhTamGiac htg=new HinhTamGiac(a,b,c);
        htg.chuvi();
        htg.dientich();
        Console.WriteLine("---HINH VUONG---");
        Console.Write("Canh hinh vuong: ");
        float x=float.Parse(Console.ReadLine());
        HinhVuong hv=new HinhVuong(r);
        hv.chuvi();
        hv.dientich();
    }
}