using System;
class khachhang
{
    public string tenKH;
    public int giave;
    public static int doanhthu=0;
    
    public void xuat()
    {
        Console.Write($"Ten khach hang: {tenKH}");
    }
    public khachhang(string tenKH,int gia)
    {
        this.tenKH = tenKH; this.giave = 0;
        doanhthu += giave;
    }
    public virtual void the()
    {
        Console.WriteLine();
    }
}
class nguoilon : khachhang
{
    public string CMND;
    public nguoilon(string ten, int gia,string CMND) : base(ten,gia)
    {
        giave = 250000;
        this.CMND = CMND;
        doanhthu += giave;
    }
    public new void xuat()
    {
        base.xuat();
        Console.Write($", gia ve: {giave}, CMND: {CMND}");
    }
    public override void the()
    {
        Console.WriteLine(", Nguoi lon mang the do");
    }
}
class tre_em : khachhang
{
    public double chieucao;
    public tre_em(string ten, int gia,double chieucao) : base(ten,gia)
    {
        if (chieucao>1) {giave = 130000;} 
        this.chieucao = chieucao;
        doanhthu += giave;
    }
    public new void xuat()
    {
        base.xuat();
        Console.Write($", gia ve: {giave}, chieu cao: {chieucao}");
    }
    public override void the()
    {
        Console.WriteLine(", Tre em mang the xanh");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // string ten = "A"; 
        int gia = 0; 
        // string cmnd = "123";
        // double h = 155;
        // khachhang kh = new khachhang(ten,gia);
        // kh.xuat();kh.the();
        nguoilon a1 = new nguoilon("a1",gia,"1233");
        nguoilon a2 = new nguoilon("a2",gia,"1233");
        a1.xuat();a1.the();a2.xuat();a2.the();
        tre_em b1 = new tre_em("b1",gia,1.31);
        tre_em b2 = new tre_em("v2",gia,1);
        b1.xuat();b1.the();b2.xuat();b2.the();
        Console.WriteLine($"doanh thu: {khachhang.doanhthu}");
    }
}