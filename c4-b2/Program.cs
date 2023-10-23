class sophuc
{
    double thuc,ao;
    public sophuc(){}
    public sophuc(double thuc,double ao)
    {
        this.thuc = thuc;this.ao = ao;
    }
    public void nhap()
    {
        Console.Write("Nhap phan thuc: ");
        thuc = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap phan ao: ");
        ao = Convert.ToDouble(Console.ReadLine());
    }
    public void xuat()
    {
        Console.WriteLine("({0}) + ({1})i",thuc,ao);
    }
    public sophuc Cong(sophuc a,sophuc b)
    {
        sophuc c = new sophuc();
        thuc = a.thuc + b.thuc;
        ao = a.ao + b.ao;
        return c;
    }
    public sophuc Tru(sophuc a,sophuc b)
    {
        sophuc c = new sophuc();
        thuc = a.thuc - b.thuc;
        ao = a.ao - b.ao;
        return c;
    }
    public sophuc Nhan(sophuc a,sophuc b)
    {
        sophuc c = new sophuc();
        thuc = a.thuc*b.thuc-a.ao*b.ao;
        ao = a.thuc*b.thuc+a.ao*b.ao;
        return c;
    }
    public sophuc Chia(sophuc a,sophuc b)
    {
        sophuc c = new sophuc();
        thuc = (a.thuc*b.thuc+a.ao*b.ao)/(b.thuc*b.thuc+b.ao*b.ao);
        ao = (a.ao*b.thuc+a.thuc*b.ao)/(b.thuc*b.thuc+b.ao*b.ao);
        return c;
    }
}
class bai2c4
{
    static void Main(string[] args)
    {
        sophuc sp1 = new sophuc(1,2);
        sophuc sp2 = new sophuc();
        sp2.nhap();
        sophuc sp3 = new sophuc();
        sp3.Cong(sp1,sp2);
        Console.Write("Tong 2 so phuc: ");
        sp3.xuat();
        sp3.Tru(sp1,sp2);
        Console.Write("Hieu 2 so phuc: ");
        sp3.xuat();
        sp3.Nhan(sp1,sp2);
        Console.Write("Tich 2 so phuc: ");
        sp3.xuat();
        sp3.Chia(sp1,sp2);
        Console.Write("Thuong 2 so phuc: ");
        sp3.xuat();
        
    }
}
        // sophuc tong = new sophuc();
        // tong.Cong(sp1,sp2);
        // Console.Write("Tong 2 so phuc: ");
        // tong.xuat();
        // sophuc hieu = new sophuc();
        // hieu.Tru(sp1,sp2);
        // Console.Write("Hieu 2 so phuc: ");
        // hieu.xuat();
        // sophuc nhan = new sophuc();
        // nhan.Nhan(sp1,sp2);
        // Console.Write("Tich 2 so phuc: ");
        // nhan.xuat();
        // sophuc chia = new sophuc();
        // chia.Chia(sp1,sp2);
        // Console.Write("Thuong 2 so phuc: ");
        // chia.xuat();