// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Reflection.Metadata;

class info
{
    public string id,hoten,group;
    public static int dem=0;
    public DiemTP a;
    public info()
    {
        dem++;
        Console.Write("Ma sinh vien: ");
        id = Console.ReadLine();
        Console.Write("Ho ten: ");
        hoten = Console.ReadLine();
        Console.Write("Lop: ");
        group = Console.ReadLine();
        a = new DiemTP();
    }
    public void xuat()
    {
        Console.WriteLine($"Ma sinh vien: {id}, ho ten: {hoten}, lop: {group}, diem trung binh: {a.diemtb()}");
    }
}
class DiemTP
{
    public double tp1,tp2,tp3;
    public DiemTP()
    {
        Console.Write("TP1: ");
        tp1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("TP2: ");
        tp2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("TP3: ");
        tp3 = Convert.ToDouble(Console.ReadLine());
    }
    public double diemtb()
    {
        return 0.1*tp1+0.3*tp2+0.6*tp3;
    }
}
class Program
{
    static void Main(string[] args)
    {
        info sv1 = new info();
        info sv2 = new info();
        info sv3 = new info();
        Console.WriteLine($"So luong sinh vien trong lop hoc phan OOP la {info.dem}");
        sv1.xuat();
        sv2.xuat();
        sv3.xuat();
    }
}
