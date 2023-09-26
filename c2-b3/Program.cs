// See https://aka.ms/new-console-template for more information
using System;
class Organization
{
    public string name,country,city,address,telephone;
    public void nhap()
    {
        Console.Write("Ten doanh nghiep: ");
        name = Console.ReadLine();
        Console.Write("Quoc gia: ");
        country = Console.ReadLine();
        Console.Write("Thanh pho: ");
        city = Console.ReadLine();
        Console.Write("Dia chi: ");
        address = Console.ReadLine();
        Console.Write("So dien thoai: ");
        telephone = Console.ReadLine();
    }
    public bool check()
    {
        if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(country)
            || String.IsNullOrWhiteSpace(city) || String.IsNullOrWhiteSpace(address)
            || String.IsNullOrWhiteSpace(telephone) || telephone.Length != 10 || sdt(telephone)==false)
        {return false;}
        else {return true;}
    }
    public bool sdt(string t)
    {
        for (int i=0;i<t.Length;i++)
        {
            if (!Char.IsNumber(t[i])) {return false;}
        }
        return true;
    }
    public void xuat()
    {
        if (check()) 
        {
            Console.WriteLine("Cong ty: {0}, quoc gia: {1}, thanh pho: {2}, dia chi: {3}, so dien thoai: {4}",name,country,city,address,telephone);
        }
        else {Console.WriteLine("Nhap thong tin loi!!!");}
    }
}
class Program
{
    static void Main()
    {
        Organization tochuc = new Organization();
        tochuc.nhap();
        tochuc.xuat();
    }
}